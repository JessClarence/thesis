﻿using Humanizer.Localisation;
using Microsoft.EntityFrameworkCore;
using thesis.Core.IRepositories;
using thesis.Core.ViewModel;
using thesis.Data;
using thesis.Data.Enum;
using thesis.Models;

namespace thesis.Repositories
{
    public class AnalyticsRepository : IAnalyticsRepository
    {
        private readonly thesisContext _context;
		//area chart 
		private List<double> monthRangesApproved;
		private List<double> monthRangesCondemned;
		//horizontal bar chart
		private List<int> monthRangesOfHead;
		private List<double> monthRangesOfLiveWeight;
		//vertical bar chart
		private List<double> suspects;
		private List<double> condemneds;
		private List<double> passes;
		//piechart
		private List<double> animalType;
		//stack bars 100 chart
		private List<double> cattles;
		private List<double> carabaos;
		private List<double> swines;
		private List<double> goats;
		private List<double> chickens;
		private List<double> ducks;
		private List<double> horses;
		private List<double> sheeps;
		private List<double> ostrichs;
		private List<double> crocodiles;

		private List<analyticViewModel> analyticObject;

		public AnalyticsRepository(thesisContext context)
        {
            _context = context;
			this.monthRangesApproved = new List<double>();
			this.monthRangesCondemned = new List<double>();
			this.monthRangesOfHead = new List<int>();
			this.monthRangesOfLiveWeight = new List<double>();
			this.suspects = new List<double>();
			this.condemneds = new List<double>();
			this.passes = new List<double>();
			this.animalType = new List<double>();
			this.cattles = new List<double>();
			this.carabaos = new List<double>();
			this.swines = new List<double>();
			this.goats = new List<double>();
			this.chickens = new List<double>();
			this.ducks = new List<double>();
			this.horses = new List<double>();
			this.sheeps = new List<double>();
			this.ostrichs = new List<double>();
			this.crocodiles = new List<double>();
            this.analyticObject = new List<analyticViewModel>();
		}

        public AnalyticsViewModel GetTotalOfMeatPerTimeSeries(string timeseries, Species species, DateTime startDate, DateTime endDate)
        {


            var startOfDate = startDate;
            var currentDate = endDate;


            foreach (AnimalPart animalPart in Enum.GetValues(typeof(AnimalPart)))
            {
                var typeAnimals = PieChartAnimalTypeSeries(animalPart, startOfDate, currentDate);
                animalType.Add(typeAnimals);
            }


            // has daily
            for (DateTime date = startOfDate; date < currentDate;)
            {
                var startOfPeriod = date;
                DateTime endOfPeriod;

                if (timeseries == "Monthly")
                {
                    endOfPeriod = new DateTime(date.Year, date.Month, DateTime.DaysInMonth(date.Year, date.Month));
                    endOfPeriod = endOfPeriod < currentDate ? endOfPeriod : currentDate;
                }
                else if (timeseries == "Yearly")
                {
                    endOfPeriod = new DateTime(date.Year, 12, 31);
                    endOfPeriod = endOfPeriod < currentDate ? endOfPeriod : currentDate;
                }
                else // Default to "Daily"
                {
                    // Set the endOfPeriod to the end of the current day
                    endOfPeriod = date.Date.AddDays(1).AddTicks(-1);
                }

                // Consolidate data for the period from 'date' to 'endOfPeriod'

                // Move to the start of the next period
                if (timeseries == "Monthly")
                {
                    date = endOfPeriod.AddDays(1);
                }
                else if (timeseries == "Yearly")
                {
                    date = endOfPeriod.AddDays(1);
                }
                else // Default to "Daily"
                {
                    date = endOfPeriod.AddTicks(1);
                }

                //endOfPeriod = endOfPeriod > endDate ? endDate : endOfPeriod;

                var monthRangeApproved = AreaChartTimeSeriesRangeApproved(species, startOfPeriod, endOfPeriod);
                var monthRangeCondemned = AreaChartTimeSeriesRangeCondemned(species, startOfPeriod, endOfPeriod);

                monthRangesApproved.Add(monthRangeApproved);
                monthRangesCondemned.Add(monthRangeCondemned);

                analyticObject.Add(new analyticViewModel
                {
                    datetime = startOfPeriod.AddDays(1),
                    condemnedValue = monthRangeCondemned,
                    approvedValue = monthRangeApproved
                });

            }

            // has no daily
            for (DateTime date = startOfDate; date < currentDate;)
            {
                var startOfPeriod = date;
                DateTime endOfPeriod;

                if (timeseries == "Yearly")
                {
                    

                    endOfPeriod = new DateTime(date.Year, 12, 31);
                    endOfPeriod = endOfPeriod < currentDate ? endOfPeriod : currentDate;
                }
                else
                {
                    endOfPeriod = new DateTime(date.Year, date.Month, DateTime.DaysInMonth(date.Year, date.Month));
                    endOfPeriod = endOfPeriod < currentDate ? endOfPeriod : currentDate;
                }

                // Consolidate data for the period from 'date' to 'endOfPeriod'

                // Move to the start of the next period
                
                date = endOfPeriod.AddDays(1);
                

                //endOfPeriod = endOfPeriod > endDate ? endDate : endOfPeriod;


                var monthRangeOfHead = BarChartTimeSeriesRangeOfHead(species, startOfPeriod, endOfPeriod);
                var monthRangeOfLiveWeight = BarChartTimeSeriesRangeOfLiveWeight(species, startOfPeriod, endOfPeriod);

                var cattle = StackBarsSpeciesSeries(Species.Cattle, startOfPeriod, endOfPeriod);
                var carabao = StackBarsSpeciesSeries(Species.Carabao, startOfPeriod, endOfPeriod);
                var swine = StackBarsSpeciesSeries(Species.Swine, startOfPeriod, endOfPeriod);
                var goat = StackBarsSpeciesSeries(Species.Goat, startOfPeriod, endOfPeriod);
                var chicken = StackBarsSpeciesSeries(Species.Chicken, startOfPeriod, endOfPeriod);
                var duck = StackBarsSpeciesSeries(Species.Duck, startOfPeriod, endOfPeriod);
                var horse = StackBarsSpeciesSeries(Species.Horse, startOfPeriod, endOfPeriod);
                var sheep = StackBarsSpeciesSeries(Species.Sheep, startOfPeriod, endOfPeriod);
                var ostrich = StackBarsSpeciesSeries(Species.Ostrich, startOfPeriod, endOfPeriod);
                var crocodile = StackBarsSpeciesSeries(Species.Crocodile, startOfPeriod, endOfPeriod);

                var suspect = BarChartTimeSeriesAntemortem(species, Issue.Suspect, startOfPeriod, endOfPeriod);
                var condemned = BarChartTimeSeriesAntemortem(species, Issue.Condemned, startOfPeriod, endOfPeriod);
                var pass = BarChartTimeSeriesAntemortemPass(species, startOfPeriod, endOfPeriod);



                monthRangesOfHead.Add(monthRangeOfHead);
                monthRangesOfLiveWeight.Add(monthRangeOfLiveWeight);
                cattles.Add(cattle);
                carabaos.Add(carabao);
                swines.Add(swine);
                goats.Add(goat);
                chickens.Add(chicken);
                ducks.Add(duck);
                horses.Add(horse);
                sheeps.Add(sheep);
                ostrichs.Add(ostrich);
                crocodiles.Add(crocodile);
                suspects.Add(suspect);
                condemneds.Add(condemned);
                passes.Add(pass);

            }



            var currentDateFormatted = currentDate.ToString("MMM dd");

            var timeAbbreviationsList = new List<string>();


            
            if (timeseries == "Yearly")
            {
                int yearsApart = endDate.Year - startDate.Year;
                for (int i = 0; i < yearsApart; i++) // Loop to one less than the total to add the exact end date later
                {
                    timeAbbreviationsList.Add(new DateTime(startDate.Year + i, 1, 1).ToString("yyyy"));
                }

                timeAbbreviationsList.Add(endDate.ToString("yyyy"));
            }

            else 
            {
                int monthsApart = 12 * (endDate.Year - startDate.Year) + endDate.Month - startDate.Month;
                for (int i = 0; i < monthsApart; i++) // Loop through full months before the end date
                {
                    timeAbbreviationsList.Add(startDate.AddMonths(i).ToString("MMM yyyy")); // Use "MMM yyyy" format for month-year
                }

                if (timeAbbreviationsList.LastOrDefault() != endDate.ToString("MMM yyyy"))
                {
                    timeAbbreviationsList.Add(endDate.ToString("MMM yyyy"));
                }
            }

            // Add the current month and day if it's not already included
            if (!timeAbbreviationsList.Contains(currentDateFormatted))
            {
                timeAbbreviationsList.Add(currentDateFormatted);
            }

            var timeAbbreviationsArray = timeAbbreviationsList.ToArray();


            return new AnalyticsViewModel
            {
                monthlyRangeApproved = monthRangesApproved,
                monthlyRangeCondemned = monthRangesCondemned,
                monthlyRangeOfHead = monthRangesOfHead,
                monthlyRangeOfLiveWeight = monthRangesOfLiveWeight,
                animalTypeRange = animalType,
                Cattle = cattles,
                Carabao = carabaos,
                Swine = swines,
                Goat = goats,
                Chicken = chickens,
                Duck = ducks,
                Horse = horses,
                Sheep = sheeps,
                Ostrich = ostrichs,
                Crocodile = crocodiles,
                Suspect = suspects,
                Condemned = condemneds,
                Pass = passes,
                dayMonthYearAbbreviationsArray = timeAbbreviationsArray,

                start = startDate,
                analyObjs = analyticObject
            };

        }


        //from meatINspectionReport to Receiving DATE
        public double BarChartTimeSeriesAntemortem(Species species, Issue issue, DateTime start, DateTime end)
        {

            var barchart = _context.ConductOfInspections
            .Include(p => p.MeatInspectionReport)
            .Include(p => p.MeatInspectionReport.ReceivingReport)
            .Where(p => p.Issue == issue
                        && p.MeatInspectionReport.RepDate.Date >= start.Date
                        && p.MeatInspectionReport.RepDate.Date <= end.Date
                        && p.MeatInspectionReport.ReceivingReport != null
                        && p.MeatInspectionReport.ReceivingReport.Species == species)
            .Sum(p => p.Weight);


            return barchart;
        }
        //from meatINspectionReport to Receiving DATE
        public double BarChartTimeSeriesAntemortemPass(Species species, DateTime start, DateTime end)
        {
            var barchart = _context.PassedForSlaughters
                .Include(p => p.ConductOfInspection.MeatInspectionReport.ReceivingReport)
                .Where(p => p.ConductOfInspection.MeatInspectionReport.RepDate.Date >= start.Date
                && p.ConductOfInspection.MeatInspectionReport.RepDate.Date <= end.Date
                && p.ConductOfInspection.MeatInspectionReport.ReceivingReport.Species == species)
                .Sum(p => p.Weight);

            return barchart;
        }


        //from meatINspectionReport to Receiving DATE
        public double StackBarsSpeciesSeries(Species species, DateTime start, DateTime end)
        {
            var stackchart = _context.totalNoFitForHumanConsumptions
                .Include(p => p.Postmortem.PassedForSlaughter.ConductOfInspection.MeatInspectionReport.ReceivingReport)
                .Where(p => p.Postmortem.PassedForSlaughter.ConductOfInspection.MeatInspectionReport.RepDate.Date >= start.Date
                && p.Postmortem.PassedForSlaughter.ConductOfInspection.MeatInspectionReport.RepDate.Date <= end.Date
                && p.Postmortem.PassedForSlaughter.ConductOfInspection.MeatInspectionReport.ReceivingReport.Species == species)
                .Sum(p => p.DressedWeight);

            return stackchart;
        }
        //from meatINspectionReport to Receiving DATE
        public double PieChartAnimalTypeSeries(AnimalPart animalPart, DateTime start, DateTime end)
        {
            var piechart = _context.Postmortems
                .Include(p => p.PassedForSlaughter.ConductOfInspection.MeatInspectionReport)
                .Where(p => p.AnimalPart == animalPart
                    && p.PassedForSlaughter.ConductOfInspection.MeatInspectionReport.RepDate.Date >= start.Date
                    && p.PassedForSlaughter.ConductOfInspection.MeatInspectionReport.RepDate.Date <= end.Date)
                .Sum(p => p.Weight);

            return piechart;
        }

        public int BarChartTimeSeriesRangeOfHead(Species species, DateTime start, DateTime end)
        {
            var hbarchart = _context.ReceivingReports
                .Where(p => p.RecTime >= start.Date && p.RecTime <= end.Date
                && p.Species == species)

                .Sum(p => p.NoOfHeads);

            return hbarchart;
        }

        public double BarChartTimeSeriesRangeOfLiveWeight(Species species, DateTime start, DateTime end)
        {
            var vbarchart = _context.ReceivingReports
                .Where(p => p.RecTime >= start.Date && p.RecTime <= end.Date
                && p.Species == species)
                .Sum(p => p.LiveWeight);

            return vbarchart;
        }

        //from meatINspectionReport to Receiving DATE - gana
        public double AreaChartTimeSeriesRangeApproved(Species species, DateTime start, DateTime end)
        {
            var areaChart = _context.totalNoFitForHumanConsumptions
                .Include(p => p.Postmortem.PassedForSlaughter.ConductOfInspection.MeatInspectionReport.ReceivingReport)
                .Where(p => p.Postmortem.PassedForSlaughter.ConductOfInspection.MeatInspectionReport.RepDate.Date >= start.Date
                && p.Postmortem.PassedForSlaughter.ConductOfInspection.MeatInspectionReport.RepDate.Date <= end.Date
                && p.Postmortem.PassedForSlaughter.ConductOfInspection.MeatInspectionReport.ReceivingReport.Species == species)
                .Sum(p => p.DressedWeight);

            return areaChart;
        }
        //from meatINspectionReport to Receiving DATE - gana
        public double AreaChartTimeSeriesRangeCondemned(Species species, DateTime start, DateTime end)
        {
            var areaChart = _context.totalNoFitForHumanConsumptions
                .Include(p => p.Postmortem)
                .Where(p => p.Postmortem.PassedForSlaughter.ConductOfInspection.MeatInspectionReport.RepDate.Date >= start.Date
                && p.Postmortem.PassedForSlaughter.ConductOfInspection.MeatInspectionReport.RepDate.Date <= end.Date
                && p.Postmortem.PassedForSlaughter.ConductOfInspection.MeatInspectionReport.ReceivingReport.Species == species)
                .Sum(p => p.Postmortem.Weight);

            return areaChart;
        }


    }
}