@Code

    Dim catagory As String = "WebArt"
    Dim group As String = "Png"
    Dim extension As String = ".png"

    Dim folder As String = "/Content/Catagories/Gallery/" + catagory + "/" + group + "/"
    Dim filecount As Integer = SiteHelpers.ImageCount("Gallery/" + catagory + "/" + group + "/", extension)

End Code

<button onclick="topFunction()" id="myBtn" title="Go to top">Top</button>

<div Class="container px-4 px-lg-5">

    <!-- Heading Row-->
    <div Class="row gx-4 gx-lg-5 my-3">
        <h3 class="text-center">
            <img class="cardimage" src="~/Content/Catagories/Svg/Artwork.svg" />
            <span class="text-dark">@catagory:</span><span class="text-light fs-4"> Png</span>
        </h3>
        <p class="text-center text-light">A collection Bulldog images used by us.</p>
    </div>

    <!-- Button Row-->
    <div class="row gx-1 gx-lg-5">

        <!-- Back Button -->
        <div class="col-2 mb-2">
            <div class="h-100 text-center">
                <a class="btn btn-danger text-sucess btn-sm wagroup-btn" href="~/Gallery/Gallery">
                    <img class="backimage" src="~/Content/Catagories/Svg/backspace.svg" />
                </a>
            </div>
        </div>

        <!-- Column Button Svg -->
        <div class="col-2 mb-2">
            <div class="h-100 w-100 text-center">
                <a class="btn btn-primary btn-sm wagroup-btn" href="~/Gallery/WebArtSVG">.Svg</a>
            </div>
        </div>

        <!-- Column Button Png -->
        <div class="col-2 mb-2">
            <div class="h-100 w-100 text-center">
                <a class="btn btn-dark btn-sm wagroup-btn" href="~/Gallery/WebArtPNG">.Png</a>
            </div>
        </div>

        <!-- Column Button Jpg -->
        <div class="col-2 mb-2">
            <div class="h-100 w-100 text-center">
                <a class="btn btn-primary btn-sm wagroup-btn" href="~/Gallery/WebArtJPG">.Jpg</a>
            </div>
        </div>

        <!-- Group 04 Button -->
        <div class="col-2 mb-2">
            <div class="h-100 w-100 text-center">
                <a class="btn btn-primary btn-sm wagroup-btn" href="~/Gallery/WebArtZip">.Zip</a>
            </div>
        </div>

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
