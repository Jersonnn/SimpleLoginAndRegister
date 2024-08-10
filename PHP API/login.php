<?php
header('Content-Type: application/json');
include 'db.php';

$username = $_POST['username'];
$password = $_POST['password'];

$query = "SELECT * FROM users WHERE username='$username' AND password='$password'";
$result = mysqli_query($conn, $query);

if (mysqli_num_rows($result) > 0) {
    echo json_encode(["message" => "Login successful"]);
} else {
    echo json_encode(["message" => "Invalid username or password"]);
}
?>