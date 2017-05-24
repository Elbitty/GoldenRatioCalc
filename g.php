<?php

function calculate($to_val) {
	$NUMBER_ONE = 1;
	$i = $NUMBER_ONE;
	$j = $NUMBER_ONE;
	$tmp = 0;
	for ($val = 0; $val < $to_val; $val++) {
		$tmp = $i + $j;
		$i = $j;
		$j = $tmp;
	}
	return ($j / $i);
}

echo calculate(24) . "\n";

?>
