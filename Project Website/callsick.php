<?php
session_start();
$servername = "studmysql01.fhict.local";  
$database = 'dbi428428';
$username = "dbi428428";
$password = "spiderMan2000";
    $conn = new PDO("mysql:host=$servername;dbname=$database", $username, $password);
    $conn->setAttribute(PDO::ATTR_ERRMODE, PDO::ERRMODE_EXCEPTION);

    $sqlcheck="SELECT * FROM absence WHERE username ="."'". $_SESSION['uname']."'". "and date="."'".$_COOKIE['selectedDate']."'";
    $stmtcheck = $conn->prepare($sqlcheck);
    $stmtcheck->execute(
        [
            ':username'=>$_SESSION['uname'],
            ':date'=>$_COOKIE['selectedDate']
        ]
    );
    if($stmtcheck->rowCount() == 0)
    {

    $sqlinsert = "INSERT INTO absence (username,date,sick) VALUES (:username,:date,1)";
    $stminsert = $conn->prepare($sqlinsert);
    $stminsert->execute(
      [
          ':username'=>$_SESSION['uname'],
          ':date'=>$_COOKIE['selectedDate']
      ]
  );

  echo "true";
}
else{
    echo 'false';
}

    ?>