using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using de.etas.cebra.toolAPI.Inca;
using de.etas.cebra.toolAPI.Common;

namespace incademo
{
    public partial class FrmINCA : Form
    {
        private Inca m_Inca;
        private Experiment m_Experiment;
        private MeasureScalarData m_MeasureScalarData;
        private CalibrationScalarData m_CalibrationScalarData;
        public FrmINCA()
        {
            InitializeComponent();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            if (m_Inca == null)
                m_Inca = new Inca();
            if (m_Inca != null)
                this.txtVersion.Text = m_Inca.APIVersion();
        }

        private void btnExperiment_Click(object sender, EventArgs e)
        {
            if (m_Inca != null && m_Experiment == null)
                m_Experiment = m_Inca.GetOpenedExperiment();
        }

        private void btnGetValue_Click(object sender, EventArgs e)
        {
            GetMeasureData();
            if (m_MeasureScalarData != null)
                txtMeasureValue.Text = m_MeasureScalarData.GetDoublePhysValue().ToString();
            GetCalibrationData();
            if (m_CalibrationScalarData != null)
                txtCalibrationValue.Text = m_CalibrationScalarData.GetDoublePhysValue().ToString();
        }

        private void btnSetValue_Click(object sender, EventArgs e)
        {
            GetCalibrationData();
            if (m_CalibrationScalarData != null)
                m_CalibrationScalarData.SetDoublePhysValue(double.Parse(txtCalibrationValue.Text));
        }
        private void GetMeasureData()
        {
            if (m_Experiment == null) return;
            if (m_MeasureScalarData == null || m_MeasureScalarData.Label() != txtMeasureName.Text)
            {
                MeasureElement[] measureArray = m_Experiment.GetAllMeasureElements();
                MeasureElement measureElement = measureArray.First(x => x.GetName() == txtMeasureName.Text);
                if (measureElement != null && measureElement.IsScalar())
                    m_MeasureScalarData = measureElement.GetValue() as MeasureScalarData;
            }
        }
        private void GetCalibrationData()
        {
            if (m_Experiment == null) return;
            if (m_CalibrationScalarData == null || m_CalibrationScalarData.Label() != txtCalibrationName.Text)
            {
                CalibrationElement[] calibrationArray = m_Experiment.GetAllCalibrationElements();
                CalibrationElement calibrationElement = calibrationArray.First(x => x.GetName() == txtCalibrationName.Text);
                if (calibrationElement != null && calibrationElement.IsScalar())
                    m_CalibrationScalarData = calibrationElement.GetValue() as CalibrationScalarData;
            }
        }
    }
}
