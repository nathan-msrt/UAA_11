<?php

$uri = $_SERVER['REQUEST_URI'];

if($uri === '/index.php'){
    require_once "Templates/Biens/voirTousLesBiens.php";
}