<?php
header('Content-Type: application/json');
include 'db.php';

$username = $_POST['username'];
$password = $_POST['password'];

$query = "INSERT INTO users (username, password) VALUES ('$username', '$password')";
if (mysqli_query($conn, $query)) {
    echo json_encode(["message" => "Registration successful"]);
} else {
    echo json_encode(["message" => "Registration failed"]);
}
?>