// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.


const CitizenIdfield = document.getElementById("CitizenId");
const CitizenIdtext = document.getElementById("Citizenalert");
const SummitButton = document.getElementById('buttonsummit');
SummitButton.disabled = true;
var setbutton1=false;
var setbutton2=false;

function changebutton(){
    if(setbutton1 && setbutton2){
        // alert("hi");
        SummitButton.disabled = false;
    }
    else{
        SummitButton.disabled = true;
    }
}


CitizenIdfield.addEventListener("input", () => {
    if(CitizenIdfield.value.length!=13 ){
        // console.log(CitizenIdtext);
        CitizenIdtext.className="error";
        CitizenIdtext.textContent="Please enter 13 digit CitizenID";
        setbutton1=false;        
        
    }
    else{
        CitizenIdtext.textContent="Correct Citizenid";
        CitizenIdtext.className="success";
        setbutton1=true;
    }
    changebutton()
});


const CreditCardNumberfield = document.getElementById("CreditCardNumber");
const CreditCardNumbertext = document.getElementById("CreditCardNumberalert");

CreditCardNumberfield.addEventListener("input", () => {
    if(CreditCardNumberfield.value.length!=16 ){
        // console.log(CitizenIdtext);
        CreditCardNumbertext.className="error";
        CreditCardNumbertext.textContent="Please enter 16 digit CreditCardNumber";
        
        // SummitButton.disabled = true;
        setbutton2=false;
        
    }
    else{
        CreditCardNumbertext.textContent="Correct CreditCardNumber"; 
        CreditCardNumbertext.className="success";
         setbutton2=true;   
    }
    changebutton()
});



