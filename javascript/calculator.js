Calculator = function(){

	this.Sum = function(first, second){
		return first + second;
	}

	this.Substract = function(first, second){
		return first - second;
	}

	this.Divide = function(first, second){
		if(second == 0)
		{
			throw new Error("Don't divide with zero");
		}
		return first / second;
	}

	this.Multiply = function(first, second){
		return first * second;
	}
}