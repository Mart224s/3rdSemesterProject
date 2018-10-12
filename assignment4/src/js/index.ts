let measureConst = 28.34952;
let outputField:HTMLDivElement = <HTMLDivElement> document.getElementById("outputField");

document.getElementById("OuncesToGrams").addEventListener("click",() => OuncesToGrams());
document.getElementById("GramsToOunces").addEventListener("click",() => GramsToOunces());

function ConvertGramsToOunces():number{
    let inputWeight:number = Number((<HTMLInputElement>document.getElementById("numberInput")).value);
    return inputWeight * measureConst;
}

function ConvertOuncesToGrams():number{
    let inputWeight:number = Number((<HTMLInputElement>document.getElementById("numberInput")).value);
    return inputWeight / measureConst; 
}
function OuncesToGrams(){
    let result:number = ConvertOuncesToGrams();
    if(result > 0){

       outputField.innerHTML = result.toString() + " Ounces"; 
    }
}

function GramsToOunces(){
    let result:number = ConvertGramsToOunces();
    if(result > 0){
        outputField.innerHTML = result.toString() + " Grams";
    }
}