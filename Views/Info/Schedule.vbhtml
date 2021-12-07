@code
    Dim results As String = "https://docs.google.com/spreadsheets/d/e/2PACX-1vS_FHJRKx7Vc7gDNGCtn0KsIDN0Y9nzbrKRAmG_cSIlAjRDhzzTX_9EuSdxDj3nI3c6NBM6v0n3i-zf/pubhtml?widget=true&amp;headers=false"
    Dim schedule As String = "https://calendar.google.com/calendar/embed?height=600&wkst=1&bgcolor=%23ffffff&ctz=America%2FChicago&mode=AGENDA&src=d2F0ZXJsb29idWxsZG9nd3Jlc3RsaW5nQGdtYWlsLmNvbQ&color=%23039BE5"
End Code

<!-- Heading Row-->
<container>

    <div Class="my-3">
        <h3 class="text-center">
            Schedule
            <img class="cardimage" src="~/Content/Catagories/Svg/Schedule.svg" />
        </h3>
    </div>

    <!-- Head Coach -->
    <h3 class="py-2 text-center text-dark">Head Coach: <a class="nav-link text-white" href="~/Info/Contact">Butch Schloemann</a></h3>

    <!-- Results Sheet -->
    <p class="text-center">
        <a href="@results" target="_blank" type="link" rel="noopener noreferrer nofollow">
            <span class="text-dark">Results Sheet</span>
        </a>
    </p>

    <!-- Embedded Link -->
    
        <iframe class="container-fluid px-0 pb-4" src="@schedule" style="border: solid 1px #777; max-width: 800px" height="600" frameborder="0" scrolling="auto"></iframe>
    

</container>