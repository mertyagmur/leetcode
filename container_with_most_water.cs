// optimized solution #1
public int MaxArea(int[] height) {
        int p1 = 0; 
        int p2 = height.Length-1;
        int maxArea = 0;

        while (p1 < p2)
        {
            bool isP1Smaller = height[p1] < height[p2];
            int area = (p2-p1) * (isP1Smaller ? height[p1] : height[p2]);
            maxArea = area > maxArea ? area : maxArea;

            if (isP1Smaller)
                p1++;
            else
                p2--;
        }
        return maxArea;
    }
