@code  

    Dim siteDesigner As String = SiteHelpers.GetSiteInfo("SiteDesigner")
    Dim siteEmailDesigner As String = SiteHelpers.GetSiteInfo("SiteEmailDesigner")

    ' Page Images
    Dim designerLogo = SiteHelpers.GetSiteInfo("SiteDesignerLogo")

End Code

<div class="text-center py-0">    

    <!-- Website Design Card -->
    <div class="pt-lg-5 w-100 text-center">
        <h6 class="font-weight-bold">Website Design</h6>
    </div>

    <!-- Designer Info -->
    <div class="mb-2" style="max-width: 20em;">
        <div class="w-100 text-center">
           <a style="color: black;" href="https://mikish.com" target="_blank"><h6>@siteDesigner</h6></a>
        </div> 
    </div>

</div>