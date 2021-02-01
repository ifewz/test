public class Account {
	public void saveCustomReportAccessAttempt(String value) {
    value = make_safe(value);
    // custom implementation of DB write access - output
    external_exec.db.write.custom.accessAttempt("UPDATE tb.log.error SET msg=406 WHERE id=" + value);
  }
}
}
