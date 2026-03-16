betolt();

let kepAdatok = [];

function betolt()
{   
    fetch("kep.txt")
    .then(x=> x.text())
    .then(y =>
        {
            console.log(y);

            const sorok = y.split("\r\n");

            kepAdatok.push([])

            sorok.forEach((e,i) =>
                {
                    
                    const adatok = e.split("\s");
                    for(let j = 0;j < adatok.length;j+=3)
                    {
                        let pixel = {
                            r:parseInt(adatok[j]),
                            g:parseInt(adatok[j+1]),
                            b:parseInt(adatok[j+2]),
                        }

                        kepAdatok[i].push(pixel)
                    }
                }
            )

            console.log(sorok)

            console.log(kepAdatok)

        }
    )
}

function feladat2()
{

}