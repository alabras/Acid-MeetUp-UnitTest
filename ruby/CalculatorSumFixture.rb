require "Calculator"
require "test/unit"
#ruby CalculatorSumFixture.rb
class TestCalculatorSum < Test::Unit::TestCase

	def setup
		@calculator = Calculator.new
	end

	def teardown
    	## Nothing really
  	end

	def test_sum_with_5_and_5_return_10
		#Arrange
		#calculator = Calculator.new

		#Act
		result = @calculator.Sum(5, 5);

		#Assert
		assert_equal(10, result);
	end

	def test_sum_with_negative_5_and_5_then_10_negative
		#Arrange
		#calculator = Calculator.new

		#Act
		result = @calculator.Sum(-5, -5);

		#Assert
		assert_equal(-10, result);
	end
end