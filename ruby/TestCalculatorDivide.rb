require "Calculator"
require "test/unit"
#ruby CalculatorSumFixture.rb
class TestCalculatorDivide < Test::Unit::TestCase

	def setup
		@calculator = Calculator.new
	end

	def teardown
    	## Nothing really
  	end

	def test_divide_with_10_and_5_return_2
		#Arrange
		#calculator = Calculator.new

		#Act
		result = @calculator.Divide(10, 5);

		#Assert
		assert_equal(2, result);
	end

	def test_divide_with_zero_then_return_throw_exception
		#Arrange
		#calculator = Calculator.new

		#Act
		assert_raise ZeroDivisionError do @calculator.Divide(10, 0) end
	end
end