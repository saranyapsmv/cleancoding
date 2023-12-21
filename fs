class fibonacciSeries
{
    public static void main(String args[])
    {
        int elementposition=1,count=10,firstelement=0,nextelement=1;
        System.out.println(firstelement+nextelement);
        for(elementposition=2;elementposition<count;++elementposition)
        {
            int sumofprev2=firstelement+nextelement;
            firstelement=nextelement;
            System.out.println(""+sumofprev2);
            nextelement=sumofprev2;
            elementposition++;
            
        }
    }
}
