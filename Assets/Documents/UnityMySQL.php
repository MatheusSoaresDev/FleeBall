<?php
include ("conexao.php");

/*if($_POST["action"] == "login")
{
	$email = $_POST['Email'];
	$senha = $_POST['senha'];
	
	$queryUnico = "SELECT `user_email`, `user_nickname`,`user_pass`, `user_bestscore` FROM `BDFleeBall` WHERE `user_email` = '$email'"; 
	$resultado = mysqli_query($conecta , $queryUnico)or die ('Falhou ' . mysqli_error());
	$quantidadeResult = mysqli_num_rows($resultado);
	
	if($quantidadeResult == 0){
		echo 'The user is not registered!';
	}else{
		$linha = mysqli_fetch_array($resultado);
		if($linha['user_pass'] == $senha)
		{
			echo 'LOGGED';
		}else{
			echo 'Incorrect password. Please try again';
		}
	}
}*/

if($_POST["action"] == "login")
{
	$nickName = $_POST['nickName'];
	
	$queryUnico = "SELECT `user_nickname` FROM `BDFleeBall` WHERE `user_nickname` = '$nickName'"; 
	$resultado = mysqli_query($conecta , $queryUnico)or die ('Falhou ' . mysqli_error());
	$quantidadeResult = mysqli_num_rows($resultado);
	
	if($quantidadeResult == 0){
		echo 'Conta nao encontrada';
	}else{
		$linha = mysqli_fetch_array($resultado);
			echo 'Conta Econtrada';
	}
}
if($_POST["action"] == "register")
{
	$nickName = $_POST['nickName'];
	
	$queryUnico = "SELECT * FROM `BDFleeBall` WHERE `user_nickname` = '$nickName'"; 
	$resultado = mysqli_query($conecta , $queryUnico)or die ('Falhou ' . mysqli_error());
	$quantidadeResult = mysqli_num_rows($resultado);
	
	if(strlen($nickName) > 5 && strlen($nickName) <= 10)
	{
		if($quantidadeResult == 0){
			$query = "INSERT INTO `BDFleeBall` (`user_nickname`) VALUES ('$nickName')";
			mysqli_query($conecta , $query)or die ('Falhou ' . mysqli_error());
			echo 'User successfully created!';
		}else{
			echo 'User already exists!';
		}
	}else{
		echo 'The name must be from six to ten caracteres!';
	}
	}
if($_POST["action"] == "BestScore")
{
	$nickName = $_POST['nickName'];
	$pontosResultado = $_POST['bestscorePlayer'];
	
	$queryUnico = "SELECT `user_nickname`, `user_bestscore` FROM `BDFleeBall` WHERE `user_nickname` = '$nickName'"; 
	$resultado = mysqli_query($conecta , $queryUnico)or die ('Falhou ' . mysqli_error());
	$linha = mysqli_fetch_array($resultado);
	$queryAtualizaPontos = "UPDATE `BDFleeBall` SET `user_bestscore` = '$pontosResultado' WHERE `user_bestscore` <= '$pontosResultado' && `user_nickname` = '$nickName'";
	$resultadoP = mysqli_query($conecta, $queryAtualizaPontos) or die ('Falhou' . mysqli_error());
}
if($_POST["action"] == "PegaStats")
{
	$nickName = $_POST['nickName'];
	
	$queryUnico = "SELECT `user_bestscore` FROM BDFleeBall WHERE `user_nickname` = '$nickName'"; 
	$resultado = mysqli_query($conecta , $queryUnico)or die ('Falhou ' . mysqli_error());
	$linha = mysqli_fetch_array($resultado);
	
	echo $linha['user_bestscore'];

}
if($_POST["action"] == "pegaRank")
{
		
	$queryPegaRank = "SELECT user_nickname, user_bestscore FROM BDFleeBall ORDER BY user_bestscore DESC LIMIT 50"; 
	$resultado = mysqli_query($conecta , $queryPegaRank)or die ('Falhou ' . mysqli_error());
	
	while($linha = mysqli_fetch_array($resultado))
	{
		echo $linha['user_nickname'] . " - ";
		echo $linha['user_bestscore'] . "|";
	}

}

if($_POST["action"] == "profileNickname")
{
	$nickName = $_POST['nickName'];
	
	$queryUnico = "SELECT user_nickname FROM BDFleeBall WHERE user_nickname = '$nickName'"; 
	$resultado = mysqli_query($conecta , $queryUnico)or die ('Falhou ' . mysqli_error());
	$linha = mysqli_fetch_array($resultado);
	
	echo $linha['user_nickname'];

}
if($_POST["action"] == "profileBestScore")
{
	$nickName = $_POST['nickName'];
	
	$queryUnico = "SELECT user_bestscore FROM BDFleeBall WHERE user_nickname = '$nickName'"; 
	$resultado = mysqli_query($conecta , $queryUnico)or die ('Falhou ' . mysqli_error());
	$linha = mysqli_fetch_array($resultado);
	
	echo $linha['user_bestscore'];
}

















?>
