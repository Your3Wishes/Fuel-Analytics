using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareEngineeringProject2016
{
    class PatternFinder
    {
        private string dataTree;

        public void findPatterns(string filePath)
        {
            try
            {
                weka.core.Instances insts = new weka.core.Instances(new java.io.FileReader(filePath));
                insts.setClassIndex(insts.numAttributes() - 1);

                // A classifier for decision trees:
                weka.classifiers.trees.J48 j48 = new weka.classifiers.trees.J48();

                
                weka.classifiers.Evaluation eval = new weka.classifiers.Evaluation(insts);

                // 10 Crossfold validation
                eval.crossValidateModel(j48, insts, 10, new java.util.Random(1));

                // Run data mining
                j48.buildClassifier(insts);
                dataTree = "Patterns found... \n" + j48.toString();
            }

            catch (java.lang.Exception ex)
            {
                ex.printStackTrace();
            }
        }

        public string getDataTree()
        {
            return dataTree;
        }
    }
}
