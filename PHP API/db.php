<?php
$servername = "localhost";
$username = "hrpfmxnd_testapi";
$password = "qYDtvPvfn9n8TjJ7LyfS";
$dbname = "hrpfmxnd_testapi";

$conn = mysqli_connect($servername, $username, $password, $dbname);

if (!$conn) {
    die("Connection failed: " . mysqli_connect_error());
}
?>