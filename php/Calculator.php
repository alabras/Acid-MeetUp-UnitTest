<?php

class Calculator
{

    public function Sum($first, $second)
    {
	   return $first + $second;
    }

    public function Substract($first, $second)
    {
	   return $first - $second;
    }

    public function Divide($first, $second)
    {
	   if($second == 0)
       {
            throw new DivisionByZeroException('Division by zero.');
       }
       return $first / $second;
    }

    public function Multiply($first, $second)
    {
        return $first * $second;
    }
}

class DivisionByZeroException extends Exception { }
?>