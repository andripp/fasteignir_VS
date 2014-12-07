<!DOCTYPE html>
<html>
<head>
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>@ViewBag.Title - My ASP.NET Application</title>
    @Styles.Render("~/Content/css")
    @Scripts.Render("~/bundles/modernizr")
    
    <style>
        html, body, #map-canvas {
            margin: 0;
            padding: 0;
            height: 100%;
        }
    </style>

    <script src="https://maps.googleapis.com/maps/api/js?libraries=visualization"></script>
    <script type="text/javascript" src="data/lo.js"></script>
    <script type="text/javascript" src="Scripts/scripts.js"></script>

</head>
<body>
    <div class="navbar navbar-inverse navbar-fixed-top">
        <div class="container">
            <div class="navbar-header">
                <button type="button" class="navbar-toggle" data-toggle="collapse" data-target=".navbar-collapse">
                    <span class="icon-bar"></span>
                    <span class="icon-bar"></span>
                    <span class="icon-bar"></span>
                </button>
                @Html.ActionLink("Fasteignir", "Index", "Home", New With {.area = ""}, New With {.class = "navbar-brand"})
            </div>
            <div class="navbar-collapse collapse">
                <ul class="nav navbar-nav">
                    <li><input onclick="clearMarkers();" type=button value="Fela allar eignir"></li>
                    <li><input onclick="showMarkers();" type=button value="S&#253;na allar eignir"></li>
                    <li><input onclick="showUnder20();" type=button value="< 20 m"></li>
                    <li><input onclick="show20to30();" type=button value="20-30 m"></li>
                </ul>
          
            </div>
        </div>
    </div>
    <div class="container body-content">
        @RenderBody()
        <hr />
    </div>
    <div id="map-canvas"></div>

    @Scripts.Render("~/bundles/jquery")
    @Scripts.Render("~/bundles/bootstrap")

</body>
</html>
