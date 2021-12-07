@Code
    ' Get Title and Site Name
    ViewData("Title") = ViewData("Message")
End Code

<div Class="container px-4 px-lg-5">

    <!-- Heading Row-->
    <div Class="row gx-4 gx-lg-5 align-items-end mb-3">

        <!-- Brand and description -->
        @Html.Partial("Cards/About/_Brand")

        <!-- Image Carousel -->
        @Html.Partial("_Carousel")

    </div>

    <!-- Content Row-->
    <div class="row gx-1 gx-lg-5">

        <!-- Schedule Card -->
        @Html.Partial("Cards/About/_Schedule")

        <!-- Fundraising Card -->
        @Html.Partial("Cards/About/_Fundraising")

        <!-- Merchandise Card -->
        @Html.Partial("Cards/About/_Merchandise")

    </div>

    <!-- Important Info Card -->
    <div class="row gx-1 gx-lg-5">
        @Html.Partial("Cards/About/_Links")
    </div>
</div>
