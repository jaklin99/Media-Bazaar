<?php
session_start();
header("Expires: Tue, 01 Jan 2000 00:00:00 GMT");
header("Last-Modified: " . gmdate("D, d M Y H:i:s") . " GMT");
header("Cache-Control: no-store, no-cache, must-revalidate, max-age=0");
header("Cache-Control: post-check=0, pre-check=0", false);
header("Pragma: no-cache");
error_reporting(0);

  ?>
<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <meta
      name="viewport"
      content="width=device-width, initial-scale=1, shrink-to-fit=no"
    />
    <link
      rel="stylesheet"
      href="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/css/bootstrap.min.css"
      integrity="sha384-Gn5384xqQ1aoWXA+058RXPxPg6fy4IWvTNh0E263XmFcJlSAwiGgFAW/dAiS6JXm"
      crossorigin="anonymous"
    />
    <link rel="stylesheet" href="editInfo.css" />
    <title>Change password</title>
</head>
<body>
<?php
require_once "navBar.php";
?>
<div class="container">
    <h1>Change Password</h1>
  	<hr>
	<div class="row" style="margin-left: 40%">

        <form method="POST"name="form3">
        
          <div class="form-group">
            <label class="col-lg-3 control-label">Old Password:</label>
            <div class="col-lg-16">
              <input class="form-control" type="password" value="" name = "opas">
            </div>
          </div>
          
          <div class="form-group">
            <label class="col-md-3 control-label">Confirm Old Password:</label>
            <div class="col-md-16">
              <input class="form-control" type="password" value="" name = "opasc">
            </div>
          </div>
          <div class="form-group">
            <label class="col-md-3 control-label">New Password:</label>
            <div class="col-md-16">
              <input class="form-control" type="password" value="" name="npas">
            </div>
          </div>
          <div class="form-group">
            <label class="col-md-3 control-label">Confirm New password:</label>
            <div class="col-md-16">
              <input class="form-control" type="password" value="" name="npasc">
            </div>
          </div>
          <div class="form-group">
            <label class="col-md-3 control-label"></label>
            <div class="col-md-16">
            <button class="btn btn-primary" name ="savepass" type="submit" style="background-color:#a5b3fe;border-color: black;color:#2f292f">
          Change Password
          </button>    
              <span></span>
              <input type="reset" class="btn btn-default" value="Cancel">

              
            </div>
          </div>
        </form>
      </div>
  </div>
</div>
</div></div>
<hr>
</body>
</html>

<?php
if(isset($_POST['savepass']))
{

  $opas = $_POST["opas"];
  $opasc = $_POST['opasc'];
  $npas = $_POST['npas'];
  $npasc = $_POST['npasc'];
  $servername = "studmysql01.fhict.local";  
    $database = 'dbi428428';
    $username = "dbi428428";
    $password = "spiderMan2000";

        $conn = new PDO("mysql:host=$servername;dbname=$database", $username, $password);
        $conn->setAttribute(PDO::ATTR_ERRMODE, PDO::ERRMODE_EXCEPTION);
        
        $sql ='SELECT password FROM users WHERE username = :username';
        $stmt = $conn->prepare($sql);
        $stmt->execute(
          [
            ':username'=> $_SESSION['uname'],
          ]
        );
        $result = $stmt->fetch();
        $dbpass = $result['password'];


        if($opas === $opasc && $opas === $dbpass)
        {
          if($npas === $npasc)
          {
            $sqlupdate = 'UPDATE users SET password = :pass WHERE username = :username';
            $stmtupdate = $conn->prepare($sqlupdate);
            $stmtupdate->execute(
              [
                ':pass' => $npas,
                ':username' => $_SESSION['uname'],
              ]
              );
        $message = "Your password has been changed. You will be logged out in 5 seconds.";
        echo "<script type='text/javascript'>alert('$message');</script>";
        sleep(5);
        session_destroy();
        redirect("location:Index.php");
          }

        }
        else{
          $message = "Incorrect Password.";
        echo "<script type='text/javascript'>alert('$message');</script>";
        redirect('location:changePassword.php');
        
        

        }

        echo "we got here";



        $conn = null;
}