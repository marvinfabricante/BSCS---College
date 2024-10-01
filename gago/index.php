<?php
// joi
$host = 'localhost';
$dbname = 'Registrationdb';
$user = 'postgres';
$password = 'Phpppppp';

$message = "";

if ($_SERVER["REQUEST_METHOD"] === "POST") {
    $username = htmlspecialchars(trim($_POST['username']));
    $email = htmlspecialchars(trim($_POST['email']));
    $phone = htmlspecialchars(trim($_POST['phone']));
    $address = htmlspecialchars(trim($_POST['address']));

    try {
        $dsn = "pgsql:host=$host;dbname=$dbname";
        $pdo = new PDO($dsn, $user, $password);
        $pdo->setAttribute(PDO::ATTR_ERRMODE, PDO::ERRMODE_EXCEPTION);

        $query = "INSERT INTO Users (Username, Email, PhoneNumber, Address) VALUES (:username, :email, :phone, :address)";
        $stmt = $pdo->prepare($query);
        $stmt->bindParam(':username', $username);
        $stmt->bindParam(':email', $email);
        $stmt->bindParam(':phone', $phone);
        $stmt->bindParam(':address', $address);

        if ($stmt->execute()) {
            $message = "User registered successfully!";
        }
    } catch (PDOException $e) {
        $message = "Error: " . $e->getMessage();
    }
}
?>

<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>User Registration</title>
    <link href="https://cdn.jsdelivr.net/npm/tailwindcss@2.2.19/dist/tailwind.min.css" rel="stylesheet">
</head>
<body class="bg-gray-100 flex items-center justify-center min-h-screen">
    <div class="bg-white p-10 rounded-xl shadow-lg w-96">
        <h1 class="text-3xl font-bold text-center text-gray-800 mb-6">User Registration</h1>

        <?php if ($message): ?>
            <p class="text-red-500 text-center mb-4"><?php echo $message; ?></p>
        <?php endif; ?>

        <form action="" method="POST">
            <div class="mb-5">
                <label for="username" class="block text-sm font-medium text-gray-700">Username:</label>
                <input type="text" id="username" name="username" required class="mt-1 block w-full p-3 border border-gray-300 rounded-lg focus:ring focus:ring-blue-500 focus:outline-none" />
            </div>

            <div class="mb-5">
                <label for="email" class="block text-sm font-medium text-gray-700">Email:</label>
                <input type="email" id="email" name="email" required class="mt-1 block w-full p-3 border border-gray-300 rounded-lg focus:ring focus:ring-blue-500 focus:outline-none" />
            </div>

            <div class="mb-5">
                <label for="phone" class="block text-sm font-medium text-gray-700">Phone Number:</label>
                <input type="text" id="phone" name="phone" required class="mt-1 block w-full p-3 border border-gray-300 rounded-lg focus:ring focus:ring-blue-500 focus:outline-none" />
            </div>

            <div class="mb-5">
                <label for="address" class="block text-sm font-medium text-gray-700">Address:</label>
                <input type="text" id="address" name="address" required class="mt-1 block w-full p-3 border border-gray-300 rounded-lg focus:ring focus:ring-blue-500 focus:outline-none" />
            </div>

            <button type="submit" class="w-full bg-blue-600 text-white py-3 rounded-lg shadow-md hover:bg-blue-700 transition duration-200 ease-in-out">Register</button>
        </form>
    </div>
</body>
</html>
