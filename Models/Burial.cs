using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace justTesting.Models
{
    public partial class Burial
    {
        public string BurialId { get; set; }
        public int OurId { get; set; }
        public string BurialSiteId { get; set; }
        public string BurialLocationNs { get; set; }
        public string BurialLocationEw { get; set; }
        public string LowPairNs { get; set; }
        public string HighPairNs { get; set; }
        public string LowPairEw { get; set; }
        public string HighPairEw { get; set; }
        public string BurialSubplot { get; set; }
        public decimal? BurialDepthMeters { get; set; }
        public string SouthToHead { get; set; }
        public string SouthToFeet { get; set; }
        public string WestToHeadMeters { get; set; }
        public string WestToFeet { get; set; }
        public string FaceBundle { get; set; }
        public string BurialWrapping { get; set; }
        public string BurialSituation { get; set; }
        public string Cluster { get; set; }
        public decimal? BurialLengthMeters { get; set; }
        public string BurialNumber { get; set; }
        public string SampleNumber { get; set; }
        public string GenderGe { get; set; }
        public string GeFunctionTotal { get; set; }
        public string GenderBodyCol { get; set; }
        public string Osteophytosis { get; set; }
        public string Robust { get; set; }
        public string ArtifactsDescription { get; set; }
        public string HairColor { get; set; }
        public string PreservationIndex { get; set; }
        public string BurialPreservation { get; set; }
        public string HairTaken { get; set; }
        public string SoftTissueTaken { get; set; }
        public string BoneTaken { get; set; }
        public string ToothTaken { get; set; }
        public string TextileTaken { get; set; }
        public string DescriptionOfTaken { get; set; }
        public string ArtifactFound { get; set; }
        public string EstimateAge { get; set; }
        public string AgeCategory { get; set; }
        public string EstimateLivingStature { get; set; }
        public string ToothAttrition { get; set; }
        public string ToothEruption { get; set; }
        public string PathologyAnomalies { get; set; }
        public string EpiphysealUnion { get; set; }
        public string BodyAnalysis { get; set; }
        public string YearFound { get; set; }
        public string MonthFound { get; set; }
        public string DayFound { get; set; }
        public string HeadDirection { get; set; }
        public string Gamous { get; set; }
        public string FieldBook { get; set; }
        public string FieldBookPageNumber { get; set; }
        public string FieldBookNotes { get; set; }
        public string ByuHasSample { get; set; }
        public string OsteologyUnknownComment { get; set; }
        public string TemporalMandibularJointOsteoarthritisTmjOa { get; set; }
        public string PostcraniaAtMagazine { get; set; }
        public string LinearHypoplasiaEnamel { get; set; }
        public string PostcraniaTrauma { get; set; }
        public string Area { get; set; }
        public string Tomb { get; set; }
        public string Rack { get; set; }
        public string Shelf { get; set; }
        public string OsteologyNotes { get; set; }
        public string SampleTaken { get; set; }
        public string SexMethod { get; set; }
        public string AgeMethod { get; set; }
        public string BurialArtifactDescription { get; set; }
        public string BuriedWithArtifacts { get; set; }
    }
}
