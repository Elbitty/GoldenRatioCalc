"""
Golden Ratio
"""

def calculate(to_val: int) -> float:
    NUMBER_ONE = int(1)
    i = NUMBER_ONE
    j = NUMBER_ONE
    tmp = 0
    for val in range(to_val):
        tmp = i + j
        i = j
        j = tmp
    return j / i

if __name__ == "__main__":
    print(calculate(24))
