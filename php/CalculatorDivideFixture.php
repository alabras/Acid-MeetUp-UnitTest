<?php
require_once 'Calculator.php';

class CalculatorDivideFixture extends PHPUnit_Framework_TestCase
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

    public function test_divide_with_10_and_5_return_2()
    {
    	//Arrange
		//$this->_calculator = new Calculator;

		//Act
		$result = $this->_calculator->Divide(10, 5);

		#Assert
		$this->assertEquals(2, $result);
    }

	/**
     * @expectedException     DivisionByZeroException
     * @expectedExceptionMessage Division by zero.
     */
    public function test_divide_with_zero_then_return_throw_exception()
    {
		//Arrange
		//$this->_calculator = new Calculator;

		//Act
		$result = $this->_calculator->Divide(10, 0);
	}
}
?>