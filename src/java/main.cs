public class Account {
  @get
  public String getCurrentLoadedReport() {
    // custom implementation of DB read access - input
    String internal_report_id = external_exec.db.read.custom.session.getLoadedReport();
    return internal_report_id;
  }
 
  @post
  public void saveCustomReportError(String value) {
    // custom implementation of DB write access - output
    external_exec.db.write.custom.reportError("UPDATE tb.log.error SET msg=344 WHERE id=" + value);
  }
 
  @post
  public void saveCustomReportAccessAttempt(String value) {
    value = make_safe(value);
    // custom implementation of DB write access - output
    external_exec.db.write.custom.accessAttempt("UPDATE tb.log.error SET msg=406 WHERE id=" + value);
  }
}
