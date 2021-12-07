@code 

    Dim siteName As String = SiteHelpers.GetSiteInfo("SiteName")
    Dim siteGoogleMapURL As String = SiteHelpers.GetSiteInfo("SiteGoogleMapURL")
    Dim siteFacebookPageURL As String = SiteHelpers.GetSiteInfo("SiteFacebookPageURL")
    Dim siteContact As String = SiteHelpers.GetSiteInfo("SiteContact")
    Dim siteEmailContact As String = SiteHelpers.GetSiteInfo("SiteEmailContact")
    Dim address1 As String = SiteHelpers.GetSiteInfo("Address1")
    Dim address2 As String = SiteHelpers.GetSiteInfo("Address2")
    Dim phone1 As String = SiteHelpers.GetSiteInfo("Phone1")

    ' Page Images
    Dim smallLogo = SiteHelpers.GetSiteInfo("SmallLogo")

End Code

<div class="text-center py-0">

    <!-- Please Contact us Text -->
    <div class="pt-4">
        <h3 class="font-weight-bold">Contact Us</h3>
    </div>

    <!-- Contact Info box -->
    <div class="card mx-auto border-dark mb-3" style="max-width: 24rem;">
        <div class="card-header w-100 text-center"><h6><img class="smalllogo fw-bold" src=@smallLogo alt="brand logo">@siteName</h6></div>
        <div class="card-body text-dark">

            <!-- Contact -->
            <div class="card-title text-start fw-bold p-0">Head Coach:</div>
            <h5 class="card-title text-start fw-bolder pb-2">@siteContact</h5>
            

            <div class="card-text text-start">
                <p>@address1<br />@address2</p>
                <p>@phone1</p>
                <p class="py-1"><a class="text-black" style="font-size: 12px;" href="mailto: @siteEmailContact">@siteEmailContact</a></p>
            </div>

            <!-- Buttons -->
            <div class="py-2">

                <!-- Facebook Page Button -->
                <div class="py-1">
                    <button style="border: none; background-color: transparent; width: 200px; border-radius:8px; padding-left: 20px;text-align: left;" onclick="newTab('@siteFacebookPageURL')">
                        <img style="height:32px; width:32px;" src="~/Content/Catagories/Svg/FB-Square.Svg" /> <b>Facebook Page</b>
                    </button>
                </div>

                <!-- Google Page Button -->
                <div class="py-1">
                    <button style="border: none; background-color: transparent; width: 200px; border-radius: 8px; padding-left: 20px; text-align: left;" onclick="newTab('@siteGoogleMapURL')">
                        <img style="height:32px; width:32px;" src="~/Content/Catagories/Svg/Google-Square.svg" /> <b>Google Maps</b>
                    </button>
                </div>

            </div>
        </div>
    </div>

</div>