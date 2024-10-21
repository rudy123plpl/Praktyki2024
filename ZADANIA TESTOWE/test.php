<?php
// Pętla for
echo "Pętla for:<br>";
for ($i = 1; $i <= 5; $i++) {
    echo "Liczba: $i<br>";
}

// Pętla foreach
echo "<br>Pętla foreach:<br>";
$owoce = ['jabłko', 'banan', 'gruszka'];
foreach ($owoce as $owoc) {
    echo "Owoc: $owoc<br>";
}

// Pętla while
echo "<br>Pętla while:<br>";
$licznik = 1;
while ($licznik <= 5) {
    echo "Licznik: $licznik<br>";
    $licznik++;
}

// Pętla do-while
echo "<br>Pętla do-while:<br>";
$licznik = 1;
do {
    echo "Licznik: $licznik<br>";
    $licznik++;
} while ($licznik <= 5);
?>
