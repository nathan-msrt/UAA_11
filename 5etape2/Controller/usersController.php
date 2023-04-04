<?php

$uri = $_SERVER['REQUEST_URI'];

if($uri === '/connexion'){
    require_once "Templates/Users/connexion.php";
}