<?php
header('Content-Type: application/json');
include 'db.php';

$username = $_POST['username'];
$password = $_POST['password'];

$hashed_password = password_hash($password, PASSWORD_BCRYPT);

$query = "INSERT INTO users (username, password) VALUES ('$username', '$hashed_password')";
if (mysqli_query($conn, $query)) {
    echo json_encode(["message" => "Registration successful"]);
} else {
    echo json_encode(["message" => "Registration failed"]);
}
?>