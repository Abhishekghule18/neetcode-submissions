public class Solution {
    public int Search(int[] nums, int target) {

        int l = 0, r = nums.Length - 1;
        while(l < r){
            int mid = ( l + r ) / 2;
            if(nums[mid] > nums[r]) l = mid + 1;
            else r = mid;
        }

        int pivot = l;

        int result = BinarySearch(nums,target, 0 , pivot-1);
        if(result != -1){
            return result;
        }

        return BinarySearch(nums, target, pivot, nums.Length - 1);
    }

    public int BinarySearch(int[] nums, int target, int l, int r){

        while(l <= r){
            int mid = (l+r)/2;
            if(nums[mid] == target){
                return mid;
            }
            else if(nums[mid] < target){
                l = mid+1;
            }
            else{
                r = mid - 1;
            }
        }
        return -1;
    }

}
