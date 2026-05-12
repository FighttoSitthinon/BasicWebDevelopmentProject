// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.


// const CitizenIdfield = document.getElementById("CitizenId");
// const CitizenIdtext = document.getElementById("Citizentext");
// const SummitButton = document.getElementById('buttonsummit');
// SummitButton.disabled = true;
// var setbutton1=false;
// var setbutton2=false;



// CitizenIdfield.addEventListener("input", () => {
//     if(CitizenIdfield.value.length!=13 ){
//         CitizenIdtext.className="error";
//         CitizenIdtext.textContent="Please enter 13 digit CitizenID";
//         setbutton1=false;        
        
//     }
//     else{
//         CitizenIdtext.textContent="Correct Citizenid";
//         CitizenIdtext.className="success";
//         setbutton1=true;
//     }
//     changebutton()
// });



// const CreditCardNumberfield = document.getElementById("CreditCardNumber");
// const CreditCardNumbertext = document.getElementById("CreditCardNumbertext");

// CreditCardNumberfield.addEventListener("input", () => {
//     if(CreditCardNumberfield.value.length!=16 ){
//         CreditCardNumbertext.className="error";
//         CreditCardNumbertext.textContent="Please enter 16 digit CreditCardNumber";
//         setbutton2=false;
        
//     }
//     else{
//         CreditCardNumbertext.textContent="Correct CreditCardNumber"; 
//         CreditCardNumbertext.className="success";
//          setbutton2=true;   
//     }
//     changebutton()
// });



var setbutton1=false;
var setbutton2=false;

function changebutton(){
    if(setbutton1 && setbutton2){
        $("#buttonsummit").prop("disabled",false);
    }
    else{
        $("#buttonsummit").prop("disabled",true);
    }
}


function ValidateCreditCard(CreditCardID){
    var sum=0;
    // CreditCardID=Number(CreditCardID);
    // console.log(CreditCardID+1)
    
    for(var i = 15; i >= 0; i--)
    {
        if (i % 2 == 1)
        {
            sum+=Number(CreditCardID[i]);
        }
        else
        {
            if ((Number(CreditCardID[i])) * 2 <= 9)
            {
                sum+=Number(CreditCardID[i]) * 2;
            }
            else
            {
                sum+=(Number(CreditCardID[i]) * 2)%10;
                sum++;
            }
        }
        
    }
// console.log(sum)
    if(sum%10==0)return true;
    else return false;
}


function ValidateCitizenId(CitizenId){
    // console.log("hi")
    var sum=0;
    for(var i = 0; i<=11 ; i++)
    {
        sum+=(13-i)*Number(CitizenId[i]);
    }
    // Console.WriteLine(sum);
    if(((11-(sum%11))%10)==(Number(CitizenId[12])))return true;
    else return false;
    // throw new NotImplementedException();
}


$(document).ready(function(){

    $("#buttonsummit").prop("disabled", true);

    $("#CitizenId").on("input", function(){
        
        if($(this).val().length!=13){
            $("#Citizentext")
            .text("Please enter 13 digit CitizenID")
            .css("color","red")
            setbutton1=false;  
        }

        else {
            
            if(ValidateCitizenId($(this).val())){
                $("#Citizentext")
                .text("Correct Citizenid")
                .css("color","green")
                setbutton1=true;
            }
            else{
                console.log("citi")
                $("#Citizentext")
                .text("InCorrect Citizenid")
                .css("color","red")
                setbutton1=false;
            }
            
        }
        changebutton()
    })


    $("#CreditCardNumber").on("input", function(){

        if($(this).val().length!=16){
            $("#CreditCardNumbertext")
            .text("Please enter 16 digit CreditCardNumber")
            .css("color","red")
            setbutton2=false;  
        }
        else {
            if(ValidateCreditCard($(this).val())){
                $("#CreditCardNumbertext")
                .text("Correct CreditCardNumber")
                .css("color","green")
                setbutton2=true;
            }
            else{
                $("#CreditCardNumbertext")
                .text("incorrect CreditCardNumber")
                .css("color","red")
                setbutton2=false;
            }
            
            
        }
        changebutton();
    })

});


