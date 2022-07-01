<?php

$conecta = mysqli_connect( "localhost" , "root", "") or print (mysqli_error());
mysqli_select_db ( $conecta , "bdfleeball") or print (mysqli_error());

?>