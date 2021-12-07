@Code
    ViewData("Title") = ViewData("Message")
End Code

<!-- Heading Row-->
<div Class="row gx-4 gx-lg-5 my-3">
    <h3 class="text-center">
        More Links
        <img class="cardimage" src="~/Content/Catagories/Svg/Links.svg" />
    </h3>
    <p class="text-center">Additional Features.</p>
</div>

<!-- Content Row-->
<div class="row gx-1 gx-lg-5">

    <!-- Back Button -->
    <div class="col-md-3 mb-2">
        <div class="h-100 text-center">
            <a class="btn btn-danger text-sucess btn-sm group-btn" href="~/Info/About">
                <img class="backimage" src="~/Content/Catagories/Svg/backspace.svg" />
            </a>
        </div>
    </div>

    <!-- Content Row-->
    <div class="row gx-1 gx-lg-5">


        <!-- Column One Card -->

        @Html.Partial("Cards/Gallery/_Pictures")

        <!-- Column Two Card -->
        @Html.Partial("Cards/Gallery/_Videos")

        <!-- Column Three Card -->
        @Html.Partial("Cards/Gallery/_Webart")

    </div>
</div>
