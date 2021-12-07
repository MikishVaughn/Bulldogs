﻿@Code

    Dim catagory As String = "Pictures"
    Dim group As String = "10"
    Dim extension As String = ".jpg"

    Dim folder As String = "http://Illustrate.net/Bulldogs/Content/Catagories/Gallery/" + catagory + "/" + group + "/"
    Dim filecount As Integer = SiteHelpers.ImageCount("Gallery/" + catagory + "/" + group + "/", extension)

End Code

<button onclick="topFunction()" id="myBtn" title="Go to top">Top</button>

<div Class="container px-4 px-lg-5">

    <!-- Heading Row-->
    <div Class="row gx-4 gx-lg-5 my-3">
        <h3 class="text-center">
            <img class="cardimage" src="~/Content/Catagories/Svg/Pictures.svg" />
            <span class="text-dark">@catagory:</span><span class="text-light fs-4"> 10</span>
        </h3>
        
    </div>

    <!-- Button Row-->
    <div class="row gx-1 gx-lg-5">

        <!-- Back Button -->
        <div class="col-3 mb-2">
            <div class="h-100 text-center">
                <a class="btn btn-danger text-sucess btn-sm group-btn" href="~/Gallery/Gallery">
                    <img class="backimage" src="~/Content/Catagories/Svg/backspace.svg" />
                </a>
            </div>
        </div>

        <!-- Group 01 Button -->
        <div class="col-3 mb-2">
            <div class="h-100 text-center">
                <a class="btn btn-primary btn-sm group-btn" href="~/Gallery/Pictures01">1</a>
            </div>
        </div>

        <!-- Group 02 Button -->
        <div class="col-3 mb-2">
            <div class="h-100 text-center">
                <a class="btn btn-primary btn-sm group-btn" href="~/Gallery/Pictures02">2</a>
            </div>
        </div>

        <!-- Group 03 Button -->
        <div class="col-3 mb-2">
            <div class="h-100 text-center">
                <a class="btn btn-primary btn-sm group-btn" href="~/Gallery/Pictures03">3</a>
            </div>
        </div>

        <!-- Group 04 Button -->
        <div class="col-3 mb-2">
            <div class="h-100 text-center">
                <a class="btn btn-primary btn-sm group-btn" href="~/Gallery/Pictures04">4</a>
            </div>
        </div>

        <!-- Group 05 Button -->
        <div class="col-3 mb-2">
            <div class="h-100 text-center">
                <a class="btn btn-primary btn-sm group-btn" href="~/Gallery/Pictures05">5</a>
            </div>
        </div>

        <!-- Group 06 Button -->
        <div class="col-3 mb-2">
            <div class="h-100 text-center">
                <a class="btn btn-primary btn-sm group-btn" href="~/Gallery/Pictures06">6</a>
            </div>
        </div>

        <!-- Group 07 Button -->
        <div class="col-3 mb-2">
            <div class="h-100 text-center">
                <a class="btn btn-primary btn-sm group-btn" href="~/Gallery/Pictures07">7</a>
            </div>
        </div>

        <!-- Group 08 Button -->
        <!--<div class="col-3 mb-2">
            <div class="h-100 text-center">
                <a class="btn btn-primary btn-sm group-btn" href="~/Gallery/Pictures08">8</a>
            </div>
        </div>-->
        <!-- Group 09 Button -->
        <!--<div class="col-3 mb-2">
            <div class="h-100 text-center">
                <a class="btn btn-primary btn-sm group-btn" href="~/Gallery/Pictures09">9</a>
            </div>
        </div>-->
        <!-- Group 10 Button -->
        <!--<div class="col-3 mb-2">
            <div class="h-100 text-center">
                <a class="btn btn-dark btn-sm group-btn" href="~/Gallery/Pictures10">10</a>
            </div>
        </div>-->

    </div>

    <!-- Image List -->
    <div class="row gx-1 gx-lg-5" id="imagelist">
        <!-- Script places stuff here -->
    </div>

</div>

<script>

    createFolderList("@folder", "@filecount", "@extension");

</script>

<script>

    // Add a "Top" button to page so we can get back to the top of the page.

    //Get the button
    var mybutton = document.getElementById("myBtn");

    // When the user scrolls down 20px from the top of the document, show the button
    window.onscroll = function () { scrollFunction() };

    function scrollFunction() {
        if (document.body.scrollTop > 20 || document.documentElement.scrollTop > 20) {
            mybutton.style.display = "block";
        } else {
            mybutton.style.display = "none";
        }
    }

    // When the user clicks on the button, scroll to the top of the document
    function topFunction() {
        document.body.scrollTop = 0;
        document.documentElement.scrollTop = 0;
    }

</script>
