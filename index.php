<?php
$handle = fopen("C:\\input.txt", "r");
if ($handle) {
	$text = "";
	
	$operation = "*"; // "*", "/", "+", "-" - operations...
	
	$result = 0;
	$first = 0;
	$second = 0;
	
	$posText = "";
	$negText = "";
	
    while (($line = fgets($handle)) !== false) {
		$text = explode(" ", $line);
		$first = (int)$text[0];
		$second = (int)$text[1];
		switch($operation){
			case "*":
				$result = (int)($first * $second);
				break;
			case "/":
				$result = (int)($first / $second);
				break;
			case "+":
				$result = (int)($first + $second);
				break;
			case "-":
				$result = (int)($first - $second);
				break;
		}
		
		if($result >= 0){
			$posText .= (string)$result."\n";
		}else{
			$negText .= (string)$result."\n";
		}		
    }
	fclose($handle);
	
	$posFile = fopen("C:\\posOutput.txt", "w");
	if($posFile){
		fwrite($posFile, $posText);
		fclose($posFile);
	}else{
		echo "Error with posFile!";
	}
	
	$negFile = fopen("C:\\negOutput.txt", "w");
	if($negFile){
		fwrite($negFile, $negText);
		fclose($negFile);
	}else{
		echo "Error with negFile!";
	}
	
} else {
	echo "Error with handle!";
} 
?>