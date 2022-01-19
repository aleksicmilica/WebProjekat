import { Bioskop } from "./Bioskop.js";









fetch("https://localhost:5001/Bioskop/Bioskopi").then(p => {
    if (p.ok) {
        p.json().then(
            bioskopi => {
                bioskopi.forEach(element => {
                    var divb= document.createElement("div");
                    divb.className="izborBioskopa";
                    divb.innerHTML=element.naziv;
                    document.body.appendChild(divb);
                    divb.onclick= (ev) =>{

                    fetch("https://localhost:5001/Film/GetFilm/" + element.id).then(
                        s => {
                            var listaFilmova = [];
                            if (s.ok) {
                                s.json().then(

                                    film => {

                                    
                                        var b = new Bioskop(element.id, element.naziv, film);
                                        var pozadina = document.body.querySelector(".pozadina");
                                        if (pozadina !== null){
                                            var rod = pozadina.parentNode;
                                            rod.removeChild(pozadina);
                                        }
                                        var izborBioskopa = document.body.querySelectorAll(".izborBioskopa");
                                        
                                        izborBioskopa.forEach(element => {
                                            let rod = element.parentNode;
                                            rod.removeChild(element);
                                        });
                                        pozadina = document.createElement("div");
                                        pozadina.className="pozadina";
                                        document.body.appendChild(pozadina);
                                        b.crtajBioskop(pozadina);
                                       

                                    })
                                
                            }
                            else
                                throw s;
                        }
                    ).catch(err => err.text().then(errMsg => alert(errMsg)));
                    }     
                });
            }
        );
    }
});

