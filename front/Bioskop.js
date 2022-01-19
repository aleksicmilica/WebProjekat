import { Korisnik } from "./Korisnik.js";
import { Projekcija } from "./Projekcija.js";
export class Bioskop {
    constructor(id, naziv, filmovi) {
        this.id = id;
        this.naziv = naziv;
        this.kont = null;
        this.filmovi = filmovi;
    }
    crtajBioskop(host) {
    
       
        this.kont=host;
        


        var red = document.createElement("div");
        red.innerHTML = this.naziv;
        red.className = "Naziv";
        this.kont.appendChild(red);
        let glavniDeo = document.createElement("div");
        glavniDeo.className = "GlavniKontejner";
     
        var korisnik = new Korisnik(this);
        
        var red2 = document.createElement("div");
        red2.className="KorisnikZaglavlje";
        var labela = document.createElement("label");
        labela.className="KorisnikZaglavljeLabela";
        labela.innerHTML = "Uloguj se";
        red2.appendChild(labela);
      
        labela.onclick=(ev)=>korisnik.crtajKorisnikaSkraceno(glavniDeo);
        labela = document.createElement("label");
        labela.className="KorisnikZaglavljeLabela";
        labela.innerHTML = "Registruj se";
        red2.appendChild(labela);
        this.kont.appendChild(red2);
        labela.onclick=(ev)=>korisnik.crtajKorisnika(glavniDeo);
        this.kont.appendChild(glavniDeo);

        this.prikaziFilmove(glavniDeo);
        



        this.crtajFilmFormu(glavniDeo);
        this.crtajKartu(glavniDeo, korisnik);








    }
    napraviFilmTabelu(host) {
        var teloTabele = host.querySelector(".TabelaFilmPodaci");

        if (teloTabele !== null) {
            var roditelj = teloTabele.parentNode;
            roditelj.removeChild(teloTabele);
        }

        
        teloTabele = document.createElement("tbody");
        teloTabele.className = "TabelaFilmPodaci";
        host.appendChild(teloTabele);





     



        return teloTabele;
    }
    dodajUTabelu(tabela,el){
        var tr = document.createElement("tr");
        tr.className="filmTabela";

        var td = document.createElement("td");
        td.className="filmTabela";
        td.innerHTML =el;
        tr.appendChild(td);





        tabela.appendChild(tr);
    }
    prikaziFilmove(host){
        let repertoarForma =document.createElement("div");
        host.appendChild(repertoarForma);
        repertoarForma.className="FilmRepertoar";
        let naslov =document.createElement("div");
        naslov.className="naslovRepertoara";
        naslov.innerHTML="Repertoar"
        repertoarForma.appendChild(naslov);
        let el = document.createElement("div");
       
        repertoarForma.appendChild(el);
        let tabela=this.napraviFilmTabelu(el);
        this.filmovi.forEach(el =>{
           
            this.dodajUTabelu(tabela,el);
        });

    }
    crtajFilmFormu(host) {
        let filmForma = document.createElement("div");
        filmForma.className = "FilmForma";
        host.appendChild(filmForma);



        var red = document.createElement("div");
        red.className = "FilmZaglavlje";
        var labela = document.createElement("label");
        labela.innerHTML = "Naziv filma: ";
        red.appendChild(labela);

        var se = document.createElement("select");
        se.className = "comboBox";

        this.filmovi.forEach((p, i) => {
            var op = document.createElement("option");
          
            op.innerHTML = p;
            op.value = p;
            se.appendChild(op);
        })
         
        red.appendChild(se);
      


       

        var btnPretrazi = document.createElement("button");
        btnPretrazi.onclick = (ev) => this.pretrazi(filmForma);
        btnPretrazi.innerHTML = "Pretrazi";
        red.appendChild(btnPretrazi);
        btnPretrazi.className="PretraziDugme";
        filmForma.appendChild(red);
      


    }
    pretrazi(host) {
        let film = host.querySelector(".comboBox");
        let nazivFilma = film.options[film.selectedIndex].value;
       
        var url = "https://localhost:5001/Projekcija/ProjekcijeZaFilm/" + nazivFilma + "/" + this.id;
       
        fetch(url, {
            method: "GET",

            headers: {
                'Content-Type': 'application/json'
            }

        }).then(s => {
            if (s.ok) {

                s.json().then(data => {
                    var tabela = this.napraviTabelu(host);
                    data.forEach(element => {
                        var vreme = element.vreme.split("T");
                        var p = new Projekcija(element.film.naziv, vreme[1], vreme[0], element.sala.naziv, this.id);
                        p.dodajUTabelu(tabela);
                       
                    });
                })
            }
        })

    }
    napraviTabelu(host) {
        var teloTabele = host.querySelector(".TabelaPodaci");

        if (teloTabele !== null) {
            var roditelj = teloTabele.parentNode;
            roditelj.removeChild(teloTabele);
        }

    
        teloTabele = document.createElement("tbody");
        teloTabele.className = "TabelaPodaci";
        host.appendChild(teloTabele);





        var tr = document.createElement("tr");
        var zag = ["FILM", "DATUM", "VREME", "SALA"];
        zag.forEach(el => {
            var th = document.createElement("th");
            th.innerHTML = el;
            tr.appendChild(th);
        })

        teloTabele.appendChild(tr);



        return teloTabele;
    }
    crtajKartu(host, korisnik) {
        var Karta = document.createElement("div");
        Karta.className = "Karta";
        host.appendChild(Karta);

        var red0 = document.createElement("div");
        red0.className = "KartaRed0";
        var labela = document.createElement("labela");
        labela.innerHTML = "brza rezervacija";
        red0.appendChild(labela);
        Karta.appendChild(red0);
    
        
        var red = document.createElement("div");
        red.className = "KartaRed1";
        var labela = document.createElement("labela");
        labela.innerHTML = "Naziv filma:";
        red.appendChild(labela);

        var se = document.createElement("select");
        se.className = "comboBox2";
        red.appendChild(se);


        Karta.appendChild(red);

        var op = document.createElement("option");
        op.innerHTML = "Unesite naziv filma";
        op.value = "";
        se.appendChild(op);
      

        this.filmovi.forEach(p => {
            op = document.createElement("option");
            op.innerHTML = p;
            op.value = p;
            se.appendChild(op);
        })
        red = document.createElement("div");
        red.className = "KartaRed2";
        labela = document.createElement("labela");
        labela.innerHTML = "Datum projekcije:";
        var se3 = document.createElement("select");
        se3.className = "comboBox3";
        var op = document.createElement("option");
        op.innerHTML = "Unesite datum projekcije";
        op.value = 0;
        se3.appendChild(op);
        red.appendChild(labela);
        red.appendChild(se3);
        Karta.appendChild(red);

        var red2 = document.createElement("div");
        red2.className = "KartaRed3";
        labela = document.createElement("labela");
        labela.innerHTML = "Vreme projekcije:";
        var se4 = document.createElement("select");
        se4.className = "comboBox4";
        op = document.createElement("option");
        op.innerHTML = "Unesite vreme projekcije";
        op.value = 0;
        se4.appendChild(op);
        red2.appendChild(labela);
        red2.appendChild(se4);

        Karta.appendChild(red2);

        se.onchange = (ev) => {
            this.obrisi(Karta);
            let film = host.querySelector(".comboBox2");
         
            if (film.selectedIndex===0)
            {
                alert("Nije unet naziv filma");
                return;
            }
            se3.value = 0;
           
            se4.value = 0;
          
            let nazivFilma = film.options[film.selectedIndex].value;
           
            var url = "https://localhost:5001/Projekcija/ProjekcijeZaFilm/" + nazivFilma + "/" + this.id;

            fetch(url, {
                method: "GET",

                headers: {
                    'Content-Type': 'application/json'
                }

            }).then(s => {
                if (s.ok) {

                    s.json().then(data => {
                        var listaVremena = [];
                        data.forEach(element => {


                            listaVremena.push(element.vreme);


                        });

                        let n = se3.length;
                        for (let i = 1; i < n; i++) {
                            se3.removeChild(se3.options[1]);

                        }

                        var listaDatuma = [];
                        listaVremena.forEach(data => {
                            var vreme = data.split("T");
                            if (listaDatuma.indexOf(vreme[0]) === -1) {
                                listaDatuma.push(vreme[0]);
                                var op = document.createElement("option");
                                op.innerHTML = vreme[0];
                                op.value = vreme[0];
                                se3.appendChild(op);
                            }
                        });
                      
                        red.appendChild(se3);
                      


                        se3.onchange = (ev) => {
                            this.obrisi(Karta);
                            se4.value = 0;
                            let n = se4.length;
                            for (let i = 1; i < n; i++) {
                                se4.removeChild(se4.options[1]);

                            }
                           
                            var listaTermina = ["Unesite vreme projekcije"];

                            let datum = host.querySelector(".comboBox3");
                            var vrednostDatume = datum.options[datum.selectedIndex].value;
                            listaVremena.forEach(el => {
                                var vreme = el.split("T");
                                if (vreme[0] === vrednostDatume && listaTermina.indexOf(vreme[1].substring(0, 5)) === -1) {
                                    vreme[1] = vreme[1].substring(0, 5);
                                    listaTermina.push(vreme[1]);


                                }
                            })
                            for (let i = 0; i < se4.length; i++) {
                                se4.remove(i);
                            }

                            listaTermina.forEach(el => {
                                var op = document.createElement("option");
                                op.innerHTML = el;
                                op.value = el;
                                se4.appendChild(op);
                            });
                            red2.appendChild(se4);
                            se4.onchange = (ev) => {
                                this.obrisi(Karta);
                                var vreme = host.querySelector(".comboBox4");
                                let vrednostVremena = vreme.options[vreme.selectedIndex].value;

                                var p = new Projekcija(nazivFilma, vrednostDatume, vrednostVremena, null, this.id);

                                p.prikaziSalu(Karta);

                                var kupiDugme = host.querySelector(".KupiDugme");
                                if (kupiDugme !== null) {
                                    var rod = kupiDugme.parentNode;
                                    rod.removeChild(kupiDugme);
                                }
                                var red3 = document.createElement("div");
                                red3.className = "KupiDugme";
                                var btnKupiKartu = document.createElement("button");
                                btnKupiKartu.className = "KupiKartuDugme"     
                                btnKupiKartu.innerHTML = "kupi kartu";
                                btnKupiKartu.onclick = (ev) => this.kupiKartu(korisnik, Karta,p);
                                red3.appendChild(btnKupiKartu);
                                Karta.appendChild(red3);

                            }
                        };

                        





                    })
                }
            })

        };







    }
    obrisi(host) {
        var salaForma = host.querySelector(".Sala");
        if (salaForma !== null) {
            var rod = salaForma.parentNode;
            rod.removeChild(salaForma);
        }
        var kupiDugme = host.querySelector(".KupiDugme");
        if (kupiDugme !== null) {
            var rod = kupiDugme.parentNode;
            rod.removeChild(kupiDugme);
        }

    }
    kupiKartu(korisnik, host,p) {
        var film = host.querySelector(".comboBox2");
        if (film.selectedIndex === 0) {
            alert("Nije izabran film");
            return;
        }
        var nazivFilma = film.options[film.selectedIndex].value;
        var datum = host.querySelector(".comboBox3");

        if (datum.selectedIndex === 0) {
            alert("Nije izabran datum projekcija");
            return;
        }
        var nazivDatuma = datum.options[datum.selectedIndex].value;
        var vreme = host.querySelector(".comboBox4");
        if (vreme.selectedIndex === 0) {
            alert("Nije izabrano vreme projekcija");
            return;

        }
        var nazivVremena = vreme.options[vreme.selectedIndex].value;

        if (korisnik.email === null) {
            alert("Nije prijavljen korisnik");
            return;
        }
        let sedista=p.sedista;
       
        for (let i = 0; i < sedista.length; i++) {

            var tmp = sedista[i];
           
            for (let j = 0; j < tmp.length; j++) {

               
                if (tmp[j] === 2) {
                
                    let red = i+1;
                    let brURedu = j+1;
                    fetch("https://localhost:5001/Karta/KupiKartu/" + this.id + "/" + nazivFilma + "/" +nazivDatuma+" "+nazivVremena + "/" + red + "/"
            + brURedu + "/" + korisnik.email, { method: "POST" }).then(
                s => {
                    if (s.ok) {
                        s.text().then(
                            t => {
                               
                               p.prikaziSalu(host);
                                alert(t);
                            }
                        )
                    }
                    else
                        throw s;

                }).catch(err => err.text().then(errMsg => alert(errMsg)));

                }
              

            }
        }
       



        
       
    }
    removeAdminFormu(host){
        var adminForma = host.querySelector(".AdminForma");
      
        if (adminForma !== null){
            let rod=adminForma.parentNode;
            rod.removeChild(adminForma);
        }
    }
    crtajAdminFormu(host) {
   
        this.removeAdminFormu(host);
        
        var adminForma = document.createElement("div");
        adminForma.className = "AdminForma";
        host.appendChild(adminForma);

      

        var red = document.createElement("div");
        labela = document.createElement("label");
        labela.innerHTML = "Naziv filma:";
        red.appendChild(labela);




        var se = document.createElement("select");
        se.className = "comboBox5";
        red.appendChild(se);
        var op = document.createElement("option");
        op.innerHTML = "Uneti naziv filma";
        op.value = 0;
        se.appendChild(op);
        this.filmovi.forEach(p => {
            op = document.createElement("option");
            op.innerHTML = p;
            op.value = p;
            se.appendChild(op);
        })

        red.className = "AdminRedovi";
        adminForma.appendChild(red);//dodat prvi cb

        red = document.createElement("div");
        var labela = document.createElement("label");
        labela.innerHTML = "Datum projekcije:";
        var se3 = document.createElement("select");
        se3.className = "comboBox6";
        var op = document.createElement("option");
        op.innerHTML = "Unesite datum projekcije";
        op.value = 0;
        se3.appendChild(op);
        red.appendChild(labela);
        red.appendChild(se3);
        red.className = "AdminRedovi";
        adminForma.appendChild(red);//dodat drugi cb

        var red2 = document.createElement("div");
        red2.className = "AdminRedovi";
        labela = document.createElement("labela");
        labela.innerHTML = "Vreme projekcije:";
        var se4 = document.createElement("select");
        se4.className = "comboBox7";
        op = document.createElement("option");
        op.innerHTML = "Unesite vreme projekcije";
        op.value = 0;
        se4.appendChild(op);
        red2.appendChild(labela);
        red2.appendChild(se4);
        adminForma.appendChild(red2);//dodat 3.cb
        this.dodajUnos(adminForma);


        se.onchange = (ev) => {

            let film = host.querySelector(".comboBox5");
            se3.value = 0;
           
            se4.value = 0;
            let nazivFilma = film.options[film.selectedIndex].value;

            var url = "https://localhost:5001/Projekcija/ProjekcijeZaFilm/" + nazivFilma + "/" + this.id;

            fetch(url, {
                method: "GET",

                headers: {
                    'Content-Type': 'application/json'
                }

            }).then(s => {
                if (s.ok) {

                    s.json().then(data => {
                        var listaVremena = [];
                        data.forEach(element => {


                            listaVremena.push(element.vreme);


                        });

                        let n = se3.length;
                        for (let i = 1; i < n; i++) {
                            se3.removeChild(se3.options[1]);

                        }

                        var listaDatuma = ["Unesite datum projekcije"];
                        listaVremena.forEach(data => {
                            var vreme = data.split("T");
                            if (listaDatuma.indexOf(vreme[0]) === -1) {
                                listaDatuma.push(vreme[0]);
                                var op = document.createElement("option");
                                op.innerHTML = vreme[0];
                                op.value = vreme[0];
                                se3.appendChild(op);
                            }
                        });
                      
                        red.appendChild(se3);
                      


                        se3.onchange = (ev) => {
                            se4.value = 0;
                            let n = se4.length;
                            for (let i = 1; i < n; i++) {
                                se4.removeChild(se4.options[1]);

                            }
                            var listaTermina = ["Unesite vreme projekcije"];

                            let datum = host.querySelector(".comboBox6");
                            var vrednostDatume = datum.options[datum.selectedIndex].value;
                            listaVremena.forEach(el => {
                                var vreme = el.split("T");
                                if (vreme[0] === vrednostDatume && listaTermina.indexOf(vreme[1].substring(0, 5)) === -1) {
                                    vreme[1] = vreme[1].substring(0, 5);
                                    listaTermina.push(vreme[1]);


                                }
                            })
                            for (let i = 0; i < se4.length; i++) {
                                se4.remove(i);
                            }

                            listaTermina.forEach(el => {
                                var op = document.createElement("option");
                                op.innerHTML = el;
                                op.value = el;
                                se4.appendChild(op);
                            });
                            
                          
                        };





                    })
                }
            })

        };


    }
    dodajUnos(host) {

        var red = host.querySelector(".AdminRedovitb");
        while (red !== null) {
            var rod = red.parentNode;
            rod.removeChild(red);
            red = host.querySelector(".AdminRedovitb");
        }


        red = document.createElement("div");
        var labela = document.createElement("label");
        labela.innerHTML = "Novi datum projekcije:";
        red.appendChild(labela);
        var tb = document.createElement("input");
        tb.setAttribute("type", "text");
        tb.setAttribute("id", "tbNDatumProj");
        tb.className="Admintb";
        red.appendChild(tb);
        red.className = "AdminRedovitb";
        host.appendChild(red);

        red = document.createElement("div");
        labela = document.createElement("label");
        labela.innerHTML = "Novo vreme projekcije:";
        red.appendChild(labela);
        tb = document.createElement("input");
        tb.setAttribute("type", "text");
        tb.setAttribute("id", "tbNVremeProj");
        tb.className="Admintb";
        red.appendChild(tb);
        red.className = "AdminRedovitb";
        host.appendChild(red);

        red = document.createElement("div");
        var btnPromeni = document.createElement("button");
        btnPromeni.onclick = (ev) => this.promeni(host);
        btnPromeni.className = "AdminDugmePromeni";
        btnPromeni.innerHTML = "Promeni";
        red.className = "AdminDugmici";
        red.appendChild(btnPromeni);
        host.appendChild(red);

    
        var btnIzbrisi = document.createElement("button");
        btnIzbrisi.onclick = (ev) => this.izbrisi(host);
        btnIzbrisi.className = "AdminDugmeBrisi";
        btnIzbrisi.innerHTML = "Izbrisi";
        red.className = "AdminDugmici";
        red.appendChild(btnIzbrisi);
        host.appendChild(red);


    }
    promeni(host) {
        var film = host.querySelector(".comboBox5");
        var nazivFilma = film.options[film.selectedIndex].value;
     
        if (film.selectedIndex === 0) {
            alert("Nije izabran film");
            return;
        }
        var datum = host.querySelector(".comboBox6");
       
        var nazivDatuma = datum.options[datum.selectedIndex].value;
        if (datum.selectedIndex === 0) {
            alert("Nije izabran datum projekcije");
            return;
        }
      
        var vreme = host.querySelector(".comboBox7");
        var nazivVremena = nazivDatuma + " " + vreme.options[vreme.selectedIndex].value;
        if (vreme.selectedIndex === 0) {
            alert("Nije izabrano vreme projekcije");
            return;

        }

        var datum2 = document.getElementById("tbNDatumProj").value;
       
        if (datum2 === "") {
            alert("Nije unet datum projekcije");
            return;
        }
        var vreme = datum2 + " " + document.getElementById("tbNVremeProj").value;
        if (vreme === "") {
            alert("Nije izabrano vreme projekcije");
            return;

        }
      
        fetch("https://localhost:5001/Projekcija/PromenitiProjekciju/" + this.id + "/" + nazivFilma + "/" + nazivVremena + "/" + vreme,
            {
                method: "PUT",
                headers: {
                    "Content-type": "application/json; charset=UTF-8"
                }
            }).then(s => {
                if(s.ok){
                    this.pretrazi()
                }
                else 
                if (!s.ok)
                    throw s;
            }
            ).catch(err => err.text().then(errMsg => alert(errMsg)));

    }
    izbrisi(host) {

        let film  = host.querySelector(".comboBox5");
        let nazivFilma = film.options[film.selectedIndex].value;
        if (film.selectedIndex == 0)
        {
            alert("Nije izabran film");
            return;
        } 
        fetch("https://localhost:5001/Film/IzbrisiFilm/"+this.id+"/"+nazivFilma,
            {
                method: "DELETE",
                headers: {
                    "Content-type": "application/json; charset=UTF-8"
                }
            }).then(s => {
                if (s.ok){
                    alert("Izbrisan je film" +nazivFilma);
                }
                else if (!s.ok)
                    throw s;
            }).catch(err =>
                err.text().then(errMsg =>
                    alert(errMsg)));

    }
}