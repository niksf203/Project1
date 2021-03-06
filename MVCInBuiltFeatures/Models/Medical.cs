﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVCInBuiltFeatures.Models
{
    public class Medical
    {
    }
    public class Student
    {
       
        public int StudentID { get; set; }
        [Display(Name = "รหัสนักศึกษา")]
        public string sid_t { get; set; }
        [Display(Name = "ชื่อ")]
        public string name { get; set; }
        [Display(Name = "นามสกุล")]
        public string sname { get; set; }
        [Display(Name = "เบอร์โทรศัพท์")]
        public string tel { get; set; }
        [Display(Name = "หมู่เลือด")]
        public string bloodtype { get; set; }
        [Display(Name = "น้ำหนัก")]
        public float weight { get; set; }
        [Display(Name = "ส่วนสูง")]
        public float height { get; set; }
        [Display(Name = "อีเมล")]
        public string email { get; set; }
        [Display(Name = "ประวัติการแพ้ยา")]
        public string drug { get; set; }
        [Display(Name = "โรคประจำตัว")]
        public string con_disease { get; set; }

        public virtual ICollection<SResult> SResults { get; set; }
        public virtual ICollection<Appointment> Appointments { get; set; }
    }

  

    public class Appointment
    {
        public int AppointmentID { get; set; }
        [Display(Name = "เรื่อง")]
        public string topic { get; set; }
        [Display(Name = "วัน/เวลาที่นัดหมาย")]
        [Required(ErrorMessage = "Enter the date.")]
        [DataType(DataType.Date)]
        public DateTime date { get; set; }
        [Display(Name = "หมายเหตุ")]
        public string des { get; set; }
        [Display(Name = "รหัสนักศึกษา")]
        public int StudentID { get; set; }
        public virtual Student Student { get; set; }
    }

    public class Info  
    {
        public int ID { get; set; }
        [Display(Name = "Header")]
        public string Header { get; set; }
        [Display(Name = "Detail")]
        public string Detail { get; set; }
        [Display(Name = "Image")]
        public string Image { get; set; }
    }


    public class Medicine 
    {
        public int MedicineID { get; set; }
        [Display(Name = "ชื่อสามัญทางยา")]
        public string MedName { get; set; }
        [Display(Name = "ชื่อทางการค้า")]
        public string MedTrade { get; set; }
        [Display(Name = "ประเภทยา")]
        public string MedType { get; set; }
        [Display(Name = "หมวดยา")]
        public string MedGroup { get; set; }
        [Display(Name = "จำนวนยาที่มี")]
        public string Rem { get; set; }
        [Display(Name = "หน่วย")]
        public string Unit { get; set; }

        public virtual ICollection<SResult> SResults { get; set; }

     
        
    }

    public class LoginStatus 
    {
        public int ID { get; set; }
        public string UserName { get; set; }
        public string Status { get; set; }
       
    }



    public class SResult
    {
        public int ID { get; set; }
        [Display(Name = "หมายเลขนัด")]
        public int SResultID { get; set; }
        [Display(Name = "วินิจฉัย")]
        public string result { get; set; }

        [Display(Name = "อาการที่มาพบ")]
        public string present_illness { get; set; }
        [Display(Name = "ตรวจร่างกาย")]
        public string vital_sign { get; set; }
        [Display(Name = "วัน/เวลาที่มาตรวจ")]
        [Required(ErrorMessage = "Enter the date.")]
        [DataType(DataType.Date)]
        public DateTime date { get; set; }


        public int Medicine_MedicineID { get; set; }
        public virtual Medicine Medicine { get; set; }

        public int StudentID { get; set; }
        public virtual Student Student { get; set; }


    }

    public class MedicalDBContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<SResult> SResults { get; set; }
        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<Info> Info { get; set; }
        public DbSet<Medicine> Medicines { get; set; }

        public System.Data.Entity.DbSet<MVCInBuiltFeatures.Models.LoginStatus> LoginStatus { get; set; }

    }
}