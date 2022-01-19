import { Bioskop } from "./Bioskop.js";
import { Korisnik } from "./Korisnik.js";

export class Projekcija {
    constructor(imeFilma, datum, vreme, sala, idBioskopa) {
        this.id = null;
        this.imeFilma = imeFilma;
        this.vreme = vreme;
        this.datum = datum;
        this.sala = sala;
        this.sedista = null;
        this.idBioskopa = idBioskopa;

    }



    dodajUTabelu(host) {
        var tr = document.createElement("tr");
       var pod = ["imeFilma", "vreme", "datum", "sala"];

        var td = document.createElement("td");
        td.innerHTML = this.imeFilma;
        tr.appendChild(td);

        td = document.createElement("td");
        td.innerHTML = this.datum;
        tr.appendChild(td);

        td = document.createElement("td");
        td.innerHTML = this.vreme;
        tr.appendChild(td);

        td = document.createElement("td");
        td.innerHTML = this.sala;
        tr.appendChild(td);




        host.appendChild(tr);
    }

    prikaziSalu(host) {

        //var sedista;
        if (this.imeFilma === "") {
            alert("Nije unet naziv filma");
            return;
        }
        if (this.datum === "") {
            alert("Nije unet datum projekcije");
            return;
        }
        if (this.vreme === "") {
            alert("Nije unet datum projekcije");
            return;
        }

        fetch("https://localhost:5001/Sala/Sala/" + this.idBioskopa + "/" + this.imeFilma + "/" + this.datum + "/" + this.vreme, { method: "GET" }).then(
            p => {
                if (p.ok) {
                    p.json().then(
                        niz => {
                         
                            niz.forEach(element => {
                                this.sedista = Array(element.brRedova).fill().map(() => Array(element.brSedistaPoRedu).fill(0));


                                fetch("https://localhost:5001/Projekcija/ProjekcijaZaFilm/" + this.idBioskopa + "/" + this.imeFilma + "/" +
                                    this.datum + "/" + this.vreme).then(
                                        s => {
                                            if (s.ok) {
                                                s.json().then(
                                                    res => {
                                                        
                                                        res.forEach(odg => {

                                                            var i = odg.brReda - 1;
                                                            var j = odg.brSedistaURedu - 1;



                                                            var tmp = this.sedista[i];
                                                            tmp[j] = 1;
                                                            this.sedista[i] = tmp;
                                                        

                                                        })
                                                        
                                                        this.crtajSalu(host);


                                                    }
                                                )

                                            }
                                            else
                                                throw s;
                                        }).catch(err => err.text().then(errMsg => alert(errMsg)));








                            });

                        })
                }
                else
                    throw p;
            }).catch(err => err.text().then(errMsg => alert(errMsg)));


    }
    crtajSalu(host) {
        var sala = host.querySelector(".Sala");
        
        if (sala !== null) {
            var roditelj = sala.parentNode;
            roditelj.removeChild(sala);
        }

        sala = document.createElement("div");
        sala.className = "Sala";
        host.appendChild(sala);
        var red;
        var polje;

        var labela;



        for (let i = 0; i < this.sedista.length; i++) {

            var tmp = this.sedista[i];
            labela = document.createElement("label");
            labela.innerHTML = i + 1;
            labela.className = "LabelaSedista";
            red = document.createElement("div");
            red.className = "RedUSali";
            red.appendChild(labela);
            for (let j = 0; j < tmp.length; j++) {

                polje = document.createElement("div");
                polje.ondblclick = (ev) => {
                   

                    this.updateSalu(i, j, host);
                }

                if (tmp[j] === 1) {
                    polje.className = "ZauzetoSediste";
                    polje.innerHTML = "z";

                }
                else if (tmp[j] == 2) {
                    polje.className = "RezervisanoSediste";
                    polje.innerHTML = "r";
                    polje.text = (i + 1) + " " + (j + 1);
                }
                else {

                    polje.className = "SlobodnoSediste";
                    polje.innerHTML = "s";

                }


                red.appendChild(polje);

            }
            sala.appendChild(red);
        }


        red = document.createElement("div");
        red.className = "RedUSali";

        for (let j = 0; j < tmp.length + 1; j++) {
            labela = document.createElement("label");
            if (j > 0)
                labela.innerHTML = j;
            else
                labela.innerHTML = "";
            labela.className = "LabelaSedista";
            red.appendChild(labela);
        }
        sala.appendChild(red);
        

    }
    updateSalu(i, j, host) {
        
        var tmp = this.sedista[i];
        if (tmp[j]==1)
        {
            alert("Izabrano mesto je zauzeto");
            return;
        }
        tmp[j] = 2;
        this.sedista[i] = tmp;

        this.crtajSalu(host);
    }

}


