#include <stdio.h>
#include <stdlib.h>

double calculate(int to_val) {
	const int NUMBER_ONE = 1;
	int i = NUMBER_ONE;
	int j = NUMBER_ONE;
	int tmp = 0;
	for (int val = 0; val < to_val; val++) {
		tmp = i + j;
		i = j;
		j = tmp;
	}
	return (j / i);
}

int main(void) {
	printf("%f\n", calculate(24));
}
