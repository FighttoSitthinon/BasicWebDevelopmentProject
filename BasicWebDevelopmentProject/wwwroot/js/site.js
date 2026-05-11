// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

$(document).ready(function () {

    function citizenvalid(value){
            let sum = 0;
            for (let i = 0; i < 12; i++)
            {
                sum += (parseInt(value[i])) * (13 - i);
            }
            let remainder = 11 - (sum % 11);
            let checkDigit = remainder % 10;
            if((parseInt(value[12])) != checkDigit)return false;
            else return true;
    }

    function creditcardvalid(card){
        let n = card.length;
            let sum = 0;
            for (let i = n - 1; i >= 0; i--)
            {
                let tmp = parseInt(card[i]);
                let pos = n - 1 - i;
                if (pos % 2 == 0)
                {
                    sum += tmp;
                }
                else
                {
                    tmp *= 2;
                    sum += tmp >= 10 ? (tmp % 10) + (Math.floor(tmp / 10)) : tmp;
                }
            }
            // Console.WriteLine(sum);
            // throw new NotImplementedException();
            if (sum % 10 != 0)return false;
            else return true;
    }

    $('#citizenid').on('change', function(){
    var value = $(this).val();
    var card = $('#creditcard').val();
    if(!citizenvalid(value)) alert("please input correct id");
    if(card && value && citizenvalid(value) && creditcardvalid(card)) alert('both input are valid!!!');
});

$('#creditcard').on('change', function(){
    var card = $(this).val();
    var value = $('#citizenid').val();
    if(card.length != 16 || !creditcardvalid(card)) alert("input correct card");
    if(card && value && citizenvalid(value) && creditcardvalid(card)) alert('both input are valid!!!');
    }

    // $('#submitform').on('submit', function(){
    //     var card = $('#creditcard').val();
    //     var value = $('#citizenid').val();
    //     var valid = !creditcardvalid(valid) && !citizenidvalid(value)
    //     if(valid)alert("valid")
    // })
    
    );
});