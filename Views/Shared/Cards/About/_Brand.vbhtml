@code
    ' Get Image Info
    Dim BigLogo As String = SiteHelpers.GetSiteInfo("BigLogo")
End Code

<div class="col-lg-5">

    <!-- Big Logo and Site Name -->
    <div class="card h-100 bg-transparent noborder" style="background-color: transparent;">
        <div class="card-body text-center p-0">
            
            <!-- Show  Big Logo -->
            <img src=@BigLogo class="img-fluid biglogo" alt="Responsive Big Logo" />

            <!-- Site Name -->
            <h2 class="font-weight-light text-white" style="text-shadow: 2px 2px 1px black, 0 0 1px black;">Youth Wrestling</h2>
            
        </div>
    </div>

    <!-- Site Description -->
    <div class="card text-white bg-dark my-2 py-2">
        <div class="card-body lh-sm shadow">
            <p class="text-white m-0 py-1">Playing on a team means learning to work with others and support them. Our goal is to develop the young athletes’ self-confidence, skill, and ability, while introducing them to the competitive sport of wrestling. </p>
            <p class="text-white m-0 py-2">What parents want most is for their children to have fun and be successful at their chosen activities, but the keys to enjoying their sports experiences lie in your hands, first by helping them choose the right sport, and then by providing a good role model for sportsmanship and commitment; that's where we can help.</p>
        </div>
    </div>

</div>
