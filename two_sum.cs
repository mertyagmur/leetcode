// bruteforce solution 199ms
public int[] TwoSum(int[] nums, int target) {
	for(int num1=0; num1<nums.Length; num1++)
	{
		for(int num2=0; num2<nums.Length; num2++)
		{
			if(num2 == num1)
			{
				continue;
			}
			if(nums[num1] + nums[num2] == target)
			{
				return new int[] {num1, num2};
			}
		}
	}
	return new int[0];
}

// better solution 115ms
public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> numsMap = new Dictionary<int, int>();
        for(int i=0; i<nums.Length; i++)
        {
            if(numsMap.TryGetValue(target-nums[i], out int value))
            {
                return new int[] {i, value};
            }
            numsMap[nums[i]] = i;
        }
        return new int[0];
    }
}
