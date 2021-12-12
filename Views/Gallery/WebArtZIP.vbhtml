@Code

    Dim catagory As String = "WebArt"
    Dim group As String = "eps"
    Dim extension As String = ".zip"

    Dim folder As String = "http://Illustrate.net/Bulldogs/Content/Catagories/Gallery/" + catagory + "/" + group + "/"
    Dim filecount As Integer = SiteHelpers.ImageCount("Gallery/" + catagory + "/" + group + "/", extension)

End Code

<button onclick="topFunction()" id="myBtn" title="Go to top">Top</button>

<div Class="container px-4 px-lg-5">

    <!-- Heading Row-->
    <div Class="row gx-4 gx-lg-5 my-3">
        <h3 class="text-center">
            <img class="cardimage" src="~/Content/Catagories/Svg/Artwork.svg" />
            <span class="text-dark">@catagory:</span><span class="text-light fs-4"> .Zip</span>
        </h3>
        <p class="text-center text-light">Master Bulldog .Zip files for printing.</p>
        <p class="text-center text-light">Contains .AI .EPS, .PDF, .SVG, and .PNG formats.</p>

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

            <!-- Group 01 Button -->
            <div class="col-2 mb-2">
                <div class="h-100 w-100 text-center">
                    <a class="btn btn-primary btn-sm wagroup-btn" href="~/Gallery/WebArtSVG">.Svg</a>
                </div>
            </div>

            <!-- Group 02 Button -->
            <div class="col-2 mb-2">
                <div class="h-100 w-100 text-center">
                    <a class="btn btn-primary btn-sm wagroup-btn" href="~/Gallery/WebArtPNG">.Png</a>
                </div>
            </div>

            <!-- Group 03 Button -->
            <div class="col-2 mb-2">
                <div class="h-100 w-100 text-center">
                    <a class="btn btn-primary btn-sm wagroup-btn" href="~/Gallery/WebArtJPG">.Jpg</a>
                </div>
            </div>

            <!-- Group 04 Button -->
            <div class="col-2 mb-2">
                <div class="h-100 w-100 text-center">
                    <a class="btn btn-dark btn-sm wagroup-btn" href="~/Gallery/WebArtZip">.Zip</a>
                </div>
            </div>

        </div>

        <!-- Image List -->
        <div class="row gx-1 gx-lg-5" id="imagelist">

            <div class="col-12 py-1">
                <a onclick="download1()" style="margin-right: auto; margin-left: auto; width: 280px; border: solid 2px; border-left-color: dimgray; border-top-color: dimgray;" class="nav-link bg-light text-center text-black py-2 rounded" id="newTab" href="#">

                    <img style="height: 160px;" src="~/Content/Catagories/Gallery/WebArt/Zip/BD-Logo-Master-Black.svg" /> <h6>Download<br />BD-Logo-Master-Black.zip</h6>
                </a>
            </div>

            <div>
                <a onclick="download2()" style="margin-right: auto; margin-left: auto; width: 280px; border: solid 2px; border-left-color: dimgray; border-top-color: dimgray;" class="nav-link bg-light text-center text-black py-2 rounded" href="#">

                    <img style="height: 160px;" src="~/Content/Catagories/Gallery/WebArt/Zip/BD-Logo-Master-White.svg" /> <h6>Download<br />BD-Logo-Master-White.zip</h6>
                </a>
            </div>

        </div>

    </div>
</div>

<script>
    @*createFolderList("@folder", "@filecount", "@extension");*@
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

<script>
    function download1() {
        var txt;
        var r = confirm("OK to Download 'BD-Logo-Master-Black.zip'?");
        if (r == true) {
            window.open("https://illustrate.net/bulldogs/Content/Catagories/Gallery/WebArt/Zip/BD-Logo-Master-Black.zip")
        } else {}
    }

    function download2() {
        var txt;
        var r = confirm("OK to Download 'BD-Logo-Master-White.zip'?");
        if (r == true) {
            window.open("https://illustrate.net/bulldogs/Content/Catagories/Gallery/WebArt/Zip/BD-Logo-Master-White.zip")
        } else {}
    }
</script>