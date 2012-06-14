<?php
require_once 'Calculator.php';

class CalculatorSumFixture extends PHPUnit_Framework_TestCase
{
	protected $_calculator = null;

	public function setUp()
    {
		$this->_calculator = new Calculator;
    }

    public function tearDown()
    {
        unset($this->_calculator);
    }

    public function test_sum_with_5_and_5_return_10()
    {
    	//Arrange
		//$this->_calculator = new Calculator;

		//Act
		$result = $this->_calculator->Sum(5, 5);

		#Assert
		$this->assertEquals(10, $result);
    }

    public function test_sum_with_negative_5_and_5_then_10_negative()
    {
		//Arrange
		//$this->_calculator = new Calculator;

		//Act
		$result = $this->_calculator->Sum(-5, -5);

		//Assert
		$this->assertEquals(-10, $result);
	}
}
?>