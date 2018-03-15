<?php
echo'<!DOCTYPE html>
<html>
	<head>
		<title>1362</title>
		<link rel="icon" href="elements/kitchen.ico">
		<link href="style.css" type="text/css" rel="stylesheet">
		<link href="elements/menu/style.css" type="text/css" rel="stylesheet">
	</head>
	<body>
		<div class="page">
			<div class="sideleft"></div>
			<div class="center">
				<div class="banner"><p>banner</p></div>';
				
				include 'elements/menu/index.html';

echo'			<div id="page">';
					
				include 'elements/pages/AboutMe/index.html';	
				
echo'			</div>
			</div>
			<div class="sideright"></div>
		</div>
	</body>
</html>';