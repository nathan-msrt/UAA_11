<!DOCTYPE html>
<html lang="fr">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>PHP_Fonctions | Nathan Massart</title>
</head>
<body>
   <?php

         $nombreDepart = 10;

        function Factorielle ( $nombreDepart )
        {
           $resultatFact = 1;
           for ($i=1; $i <= $nombreDepart; $i++) { 
            $resultatFact = $resultatFact * $i;
           } 
           return $resultatFact;
        }
         $chaineDepart = "Je fais mes revisions";
         $caractere = "e";
        function ChaineCaractere ( $chaineDepart, $caractere) 
        {
           $longueurChaine = strlen($chaineDepart);
           $nbOccurences = 0;
           for ($i=0; $i < $longueurChaine; $i++) { 
            if ($chaineDepart[$i] == $caractere) {
               $nbOccurences++;
            }
           }
           return $nbOccurences;
        }
    ?>
    <p>La factorielle de <?= $nombreDepart ?> est <?= Factorielle($nombreDepart)?></p>
    <p>Le nombre de <?= $caractere ?> dans <?= $chaineDepart ?> est de <?= ChaineCaractere($chaineDepart, $caractere)?></p>


</body>
</html>