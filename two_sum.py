# first bruteforce solution
def find_two_sum(arr, target):
    for i in range(len(arr)):
        for j in range(len(arr)):
            if arr[i] + arr[j] == target:
                return (i, j)
    return None

# final leetcode solution
def find_two_sum(nums, target):
        """
        :type nums: List[int]
        :type target: int
        :rtype: List[int]
        """
        nums_map = {}

        for i in range(len(nums)):
            num_to_find = target - nums[i]
            if num_to_find in nums_map:
                return [nums_map[num_to_find], i]
            nums_map[nums[i]] = i

if __name__ == "__main__":
    #print(find_two_sum([1, 3, 7, 9, 2], 11)) # Solution exists
    #print(find_two_sum([1, 3, 7, 9, 2], 15)) # Solution does not exist
    #print(find_two_sum([], 15)) # Empty list
    #print(find_two_sum([1], 15)) # Single element list

    print(find_two_sum([2, 7, 11, 15], 9))