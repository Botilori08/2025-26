betolt();

let kepAdatok = [];

function betolt()//1.feladat
{   
    fetch("kep.txt")
    .then(x=> x.text())
    .then(y =>
        {
            console.log(y);

            const sorok = y.split("\r\n");


            sorok.forEach(e =>
                {

                    kepAdatok.push([]);

                    let tablaSor =document.createElement("tr");


                    const adatok = e.split(" ");
                    for(let j = 0;j < adatok.length;j+=3)
                    {
                        let pixel = {
                            r:parseInt(adatok[j]),
                            g:parseInt(adatok[j+1]),
                            b:parseInt(adatok[j+2]),
                            RGB: `RGB(${adatok[j]},${adatok[j+1]},${adatok[j+2]})`
                        }

                        let cella = document.createElement("td");
                        cella.style.backgroundColor = pixel.RGB;
                        pixel["cella"] = cella;
                        tablaSor.appendChild(cella);

                        kepAdatok[kepAdatok.length-1].push(pixel);
                    }
                    document.querySelector("#kep table").appendChild(tablaSor);
        });

            console.log(sorok);

            console.log(kepAdatok);

        }
    )
}

function feladat2()
{
    
    let sor = parseInt(document.getElementById("sorSzam").value) ?? 1;
    
    let oszlop = parseInt(document.getElementById("oszlopSzam").value) ?? 1;

    document.getElementById("feladat2-eredmeny").innerHTML = kepAdatok[sor-1][oszlop-1].RGB;

    kepAdatok[sor-1][oszlop-1].cella.style.backgroundColor = yellow;


    


}