# bruteforce solution
def max_area_bruteforce(height):
    max_area = 0
    for i in range(len(height)):
        for j in range(len(height)):
            if i == j:
                continue
            area = min(height[i], height[j]) * abs(i-j)
            if area > max_area:
                max_area = area
    return max_area

# optimized solution #1
def max_area_opt1(height):
    max_area = 0
    for i in range(len(height)):
        for j in range(i, len(height)):
            if i == j:
                continue
            area = min(height[i], height[j]) * abs(i-j)
            if area > max_area:
                max_area = area
    return max_area



if __name__ == "__main__":
    print(max_area_opt1([1,8,6,2,5,4,8,3,7]))