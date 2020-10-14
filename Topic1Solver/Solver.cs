using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Runtime.InteropServices.ComTypes;
using System.Security.Cryptography;
using System.Text;

namespace Topic1Solver
{
    class Solver
    {
        int _qChoicemaker, _qCriteria, _qObjects;

        double[,] _choicemakerMatrix;

        List<double[,]> _criteriaMatrix;
        List<double[,]> _objectsMatrix;
        public Solver(int qChoicemaker, int qCriteria, int qObjects)
        {
            _qChoicemaker = qChoicemaker;
            _qCriteria = qCriteria;
            _qObjects = qObjects;

            _choicemakerMatrix = new double[_qChoicemaker, _qChoicemaker];
            _criteriaMatrix = new List<double[,]>();
            _objectsMatrix = new List<double[,]>();
        }
        
        public void SetChoicerMatrix(double[,] matrix)
        {
            _choicemakerMatrix = matrix;
        }

        public void SetCrtiteriaMatrix(List<double[,]> listMatrix)
        {
            _criteriaMatrix = listMatrix;
        }

        public void SetObjectsMatrix(List<double[,]> listMatrix)
        {
            _objectsMatrix = listMatrix;
        }

        public List<double> NormaliseMatrix(double[,] matrix, int matrixSize)
        {
            var coef = new List<double>();

            for(int j = 0; j< matrixSize; j++)
            {
                double sum = 0;
                for(int i = 0; i < matrixSize; i++)
                {
                    sum += matrix[i, j];
                }
                coef.Add(sum);
            }

            double[,] normMatrix = new double[matrixSize, matrixSize];

            for (int j = 0; j < matrixSize; j++)
            {
                for (int i = 0; i < matrixSize; i++)
                {
                    normMatrix[i,j] = matrix[i, j]/coef[j];
                }
            }

            var result = new List<double>();
            for(int i = 0; i < matrixSize; i++)
            {
                var rowResult = 0d;
                for(int j = 0; j < matrixSize; j++)
                {
                    rowResult += normMatrix[i, j];
                }
                result.Add(rowResult / matrixSize);
            }

            return result;
        }

        public (int best, List<double> coef) FindBestObject()
        {
            var choicerCoef = NormaliseMatrix(_choicemakerMatrix, _qChoicemaker);

            var listCriteriaCoef = new List<List<double>>();
            for(int i = 0; i < _qChoicemaker; i++)
            {
                var criteriaCoef = NormaliseMatrix(_criteriaMatrix[i], _qCriteria);
                listCriteriaCoef.Add(criteriaCoef);
            }

            var listObjectCoef = new List<List<double>>();
            for(int i = 0; i < _qChoicemaker * _qCriteria; i++)
            {
                var objectCoef = NormaliseMatrix(_objectsMatrix[i], _qObjects);
                listObjectCoef.Add(objectCoef);
            }

            var objectRating = new List<double>();

            for(int i = 0; i < _qObjects; i++)
            {
                var rat = 0d;
                for(int choicer = 0; choicer < _qChoicemaker; choicer++)
                {
                    var ratCriteria = 0d;
                    for(int criteria = 0; criteria < _qCriteria; criteria++)
                    {
                        ratCriteria += listCriteriaCoef[choicer][criteria] * listObjectCoef[choicer * _qCriteria + criteria][i];
                    }
                    rat += choicerCoef[choicer] * ratCriteria;
                }
                objectRating.Add(rat);
            }

            WriteToFile(choicerCoef, listCriteriaCoef, listObjectCoef);

            return (objectRating.IndexOf(objectRating.Max()), objectRating);
        }

        private void WriteToFile(List<double> choicerCoef, List<List<double>> listCriteriaCoef, List<List<double>> listObjectCoef)
        {
            var path = @"D:\Education\4 course\TPR\result.txt";

            File.WriteAllText(path, "Choicer coef");
            var stringLine = choicerCoef.Select(x => x.ToString()).Aggregate((x, y) => $"{x}; {y}");
            File.AppendAllText(path, Environment.NewLine);
            File.AppendAllText(path, stringLine);

            File.AppendAllText(path, "Criteria coef");
            File.AppendAllText(path, Environment.NewLine);
            foreach (var line in listCriteriaCoef)
            {
                stringLine = line.Select(x => x.ToString()).Aggregate((x, y) => $"{x}; {y}");
                File.AppendAllText(path, stringLine);
                File.AppendAllText(path, Environment.NewLine);
            }

            File.AppendAllText(path, "Object coef");
            File.AppendAllText(path, Environment.NewLine);
            foreach (var line in listObjectCoef)
            {
                stringLine = line.Select(x => x.ToString()).Aggregate((x, y) => $"{x}; {y}");
                File.AppendAllText(path, stringLine);
                File.AppendAllText(path, Environment.NewLine);
            }
        }
    }
}
