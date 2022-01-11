// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

 <script>
    function myFunction() {
        var price = document.getElementById("inputProductPrice").value;
        var gst = document.getElementById("inputGST").value;
        var delivery = document.getElementById("inputDelivery").value;
        var total = +price + +gst + +delivery;
        document.getElementById("totalPrice").innerHTML = total;
        
    }
</script>
