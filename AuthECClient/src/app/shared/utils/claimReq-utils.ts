export const claimReq = {
  adminOnly: (c: any) => c.role == "Admin" || c.role == "Lecturer" || c.role == "Founder" || c.role == "Director",
  hasUTnumber: (c: any) => 'UTnumber' in c,
}