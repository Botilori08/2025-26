let fileNev = "vonat.txt";

const adatok = [];

document.body.onload = betolt();

function betolt()
{
    fetch(fileNev)
    .then(x => x.text())
    .then(x =>
        {
            /*console.log(x);

            let minta = /(\d+)\t(\d+)\t(\d+)\t([IE])/g;

            let sorok = x.match(minta)
            */
            //AI Help
            const regex = /^(?<vonatId>\d+)\s+(?<allomasId>\d+)\s(?<ora>\d+)\s(?<perc>\d+)\s(?<tipus>[IE])$/gm;

            let sorok2 = x.match(regex);

            while((match = regex.exec(x)) !== null)
            {
                adatok.push(match.groups)
                adatok.at(-1)["idoPercben"] = parseInt(adatok.at(-1).ora)*60 + parseInt(adatok.at(-1).perc)
            }
            
            console.log(adatok)
            
        }
    )
}


function feladat2()
{

    let vonatSzamkiir = document.getElementById("vonatSzam");

    let allomasSzamkiir = document.getElementById("allomasSzam");

    let vonatMax = 0;
    let allomasMax = 0;

    adatok.forEach(x => {

        if(parseInt(x.vonatId) > vonatMax )
        {
            vonatMax = parseInt(x.vonatId);
            

        }
        if(parseInt(x.allomasId) > allomasMax)
        {
            allomasMax = parseInt(x.allomasId);
        }
    })

    vonatSzamkiir.innerHTML = vonatMax;

    allomasSzamkiir.innerHTML = allomasMax+1;

    //console.log(vonatMax)
}

