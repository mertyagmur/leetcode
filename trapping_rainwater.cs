// bruteforce solution
public int Trap(int[] height) {
	int totalWater = 0;
	for(int i=0; i<height.Length; i++)
	{
		int maxLeft = 0;
		int maxRight = 0;

		for(int j=i; j<height.Length; j++)
		{
			if(height[j] > maxRight)
			{
				maxRight = height[j];
			}
		}

		for(int k=i; k>=0; k--)
		{
			if(height[k] > maxLeft)
			{
				maxLeft = height[k];
			}
		}

		totalWater += Math.Min(maxLeft, maxRight) - height[i];
	}
	return totalWater;
}
