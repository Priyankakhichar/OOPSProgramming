//-------------------------------------------------------------------------------------------------------------------------------
//<copyright file = "InventeryTypes.cs" company ="Bridgelabz">
//Copyright © 2019 company ="Bridgelabz"
//</copyright>
//<creator name ="Priyanka khichar"/>
//
//-------------------------------------------------------------------------------------------------------------------------------
namespace OOPSProgramming.InventeryManagment
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    /// <summary>
    /// defining inventery Types
    /// </summary>
    class InventeryTypes
    {
        /// <summary>
        /// The rice list
        /// </summary>
        private List<RiceClass> riceList = new List<RiceClass>();

        /// <summary>
        /// The pulses list
        /// </summary>
        private List<PulsesClass> pulsesList = new List<PulsesClass>();

        /// <summary>
        /// The wheat list
        /// </summary>
        private List<WheatClass> wheatList = new List<WheatClass>();

        /// <summary>
        /// Gets or sets the rice list.
        /// </summary>
        /// <value>
        /// The rice list.
        /// </value>
        [JsonProperty("RiceList")]
        public List<RiceClass> RiceList
        {
            get
            {
                return this.riceList;
            }

            set
            {
                this.riceList = value;
            }
        }

        /// <summary>
        /// Gets or sets the pulses list.
        /// </summary>
        /// <value>
        /// The pulses list.
        /// </value>
         [JsonProperty("PulsesList")]
        public List<PulsesClass> PulsesList
        {
            get
            {
                return this.pulsesList;
            }

            set
            {
                this.pulsesList = value;
            }
        }

        /// <summary>
        /// Gets or sets the wheat list.
        /// </summary>
        /// <value>
        /// The wheat list.
        /// </value>
         [JsonProperty("WheatList")]
        public List<WheatClass> WheatList
        {
            get
            {
                return this.wheatList;
            }

            set
            {
                this.wheatList = value;
            }
        }
    }
}
