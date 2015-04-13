using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace ExternalRadixSort
{
    class RadixSortProgram
    {
        static int NUMBER_OF_INTEGERS_TO_CREATE = 10000;
        static string testDatFile = "test.dat";
        static string bucket0DatFile = "bucket0.dat";
        static string bucket1DatFile = "bucket1.dat";

        static void Main(string[] args)
        {
            //Runs the sort and the checks
            RunSortAndCheck();
        }

        static void WriteToFile(int textToWrite, BinaryWriter fileToWriteTo)
        {
            fileToWriteTo.Write(textToWrite);
        }

        static void GenerateAndWriteRandomNumbers(string fileToWriteTo)
        {
            BinaryWriter randomIntegersWriter = new BinaryWriter(File.Open(fileToWriteTo, FileMode.Create));
            Random rnd = new Random();
            //write random numbers to the file
            for (int i = 0; i < NUMBER_OF_INTEGERS_TO_CREATE; i++)
                WriteToFile(Convert.ToInt32(rnd.Next()), randomIntegersWriter);
            //stop writing
            randomIntegersWriter.Close();
        }

        static bool CheckGoodSort()
        {
            BinaryReader randomIntegersReader = new BinaryReader(File.Open(testDatFile, FileMode.Open));
            //need to initialize it with the first number
            int firstNum = -1;
            int secondNum;
            bool incorrect = false;
            int countRead = 0;
            while (!incorrect && ((countRead * 2) + 2) <= NUMBER_OF_INTEGERS_TO_CREATE) //Basically 2 get read everyTime, cant read more than that.
            {
                //Read in SecondNumber
                secondNum = randomIntegersReader.ReadInt32();
                if (firstNum > secondNum)
                {
                    incorrect = true;
                    Console.WriteLine("Out of Order");
                    return false;
                }
                //Read in FirstNumber
                firstNum = randomIntegersReader.ReadInt32();
                //Increment Count Read
                countRead++;
            }
            randomIntegersReader.Close();
            if (countRead * 2 < NUMBER_OF_INTEGERS_TO_CREATE - 1)
                Console.WriteLine("NoEnoughRead, {0} Were Read", countRead * 2);
            return true;
        }

        static void RunSortAndCheck()
        {
            Console.WriteLine("Generating Numbers\nSorting\nTiming\nVerifyingCorrectness\nLooping");
            //runs until the count is met or CheckSort returns false
            int Count = 0;
            //do while because the checkGoodSort will return false if it was never sorted.
            do
            {
                GenerateAndWriteRandomNumbers(testDatFile);
                RadixSort();
                Count++;
            } while (Count < 10000 && CheckGoodSort());

        }

        static void RadixSort()
        {
            Stopwatch stopwatch = new Stopwatch();
            BinaryWriter create0 = new BinaryWriter(File.Open(bucket0DatFile, FileMode.Create));
            BinaryWriter create1 = new BinaryWriter(File.Open(bucket1DatFile, FileMode.Create));
            create0.Close();
            create1.Close();
            int numberToMaskWith = 1;
            int currentNumberRead;
            int numberToStoreInBucket;
            int countTotalNumbersRead = 0;
            int countBucket0Read = 0;
            int countBucket1Read = 0;
            int count = 0;
            stopwatch.Start();
            while (count < 31)
            {
                //basically 2^count and then mask
                //moving the bit up 1 each time -> 0b0001 = 1 = 2^0, 0b0010 = 2 = 2^1, 0b0100 = 4 = 2^2 etc...
                numberToMaskWith = Convert.ToInt32(Math.Pow(2, count));
                //open files to write and read to
                BinaryReader randomIntegersReader = new BinaryReader(File.Open(testDatFile, FileMode.Open));
                BinaryWriter bucket0Writer = new BinaryWriter(File.Open(bucket0DatFile, FileMode.Open));
                BinaryWriter bucket1Writer = new BinaryWriter(File.Open(bucket1DatFile, FileMode.Open));

                //make sure to read all the numbers line by line
                //Peek was not working because of some encoding issue. Manual Handling! Using Constants though
                while (countTotalNumbersRead < NUMBER_OF_INTEGERS_TO_CREATE)
                {
                    //get the number to store in the bucket
                    currentNumberRead = randomIntegersReader.ReadInt32();
                    numberToStoreInBucket = currentNumberRead;
                    //mask the number with the number to mask
                    currentNumberRead = currentNumberRead & numberToMaskWith;
                    //if the bit is a 0, put in bucket0, if it is a 1, put in bucket1
                    if (currentNumberRead == 0)
                    {
                        //Keep a count
                        countBucket0Read++;
                        WriteToFile(numberToStoreInBucket, bucket0Writer);
                    }
                    else
                        WriteToFile(numberToStoreInBucket, bucket1Writer);
                    countTotalNumbersRead++;
                }
                //Close files
                bucket0Writer.Close();
                bucket1Writer.Close();
                randomIntegersReader.Close();
                //Open files
                BinaryReader firstBucketReader = new BinaryReader(File.Open(bucket0DatFile, FileMode.Open));
                BinaryReader secondBucketReader = new BinaryReader(File.Open(bucket1DatFile, FileMode.Open));
                BinaryWriter orderingNumbersProgress = new BinaryWriter(File.Open(testDatFile, FileMode.Open));
                //Write 0's and 1's to the testDatFile
                //set the Count of the bucket 1 to the difference of bucket 0 and the total
                countBucket1Read = NUMBER_OF_INTEGERS_TO_CREATE - countBucket0Read;
                while (countBucket0Read > 0)
                {
                    WriteToFile(firstBucketReader.ReadInt32(), orderingNumbersProgress);
                    countBucket0Read--;
                }
                while (countBucket1Read > 0)
                {
                    WriteToFile(secondBucketReader.ReadInt32(), orderingNumbersProgress);
                    countBucket1Read--;
                }
                //close them after finishing writing and reading
                firstBucketReader.Close();
                secondBucketReader.Close();
                orderingNumbersProgress.Close();
                //increment count for while loop.
                count++;
                //Restart this so u keep checking
                countTotalNumbersRead = 0;
            }
            stopwatch.Stop();
            TimeSpan timeElapsed = stopwatch.Elapsed;
            Console.WriteLine(timeElapsed.Milliseconds);
        }
    }
}
